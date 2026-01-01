using Script.Input;
using Scripts.Player.MovementState;
using System;
using UnityEngine;

namespace Scripts.Player {
    [System.Serializable]
    public class Movement {
        [SerializeField] private float _RunSpeed;
        [SerializeField] private float _MoveSpeed;
        [SerializeField] private float _SteltzSpeed;
        [Space]
        [SerializeField] private Rigidbody2D _RigidbodyPlayer;

        public Architecture.State.Context PlayerMovementState;

        private InputActionS _InputPlayer;
        public void UpdataMove() => PlayerMovementState?.Update();

        public Movement(float MoveSpeed, InputActionS InputPlayer, Rigidbody2D RigidbodyPlayer) {
            PlayerMovementState = new Architecture.State.Context();
            _InputPlayer = InputPlayer;
            _MoveSpeed = MoveSpeed;
            _SteltzSpeed = MoveSpeed * (_SteltzSpeed + 0.6f);
            _RunSpeed = MoveSpeed * (_RunSpeed + 1.8f);
            _RigidbodyPlayer = RigidbodyPlayer;

            PlayerMovementState.AddState(new IdleBehaviour(1488,this, _RigidbodyPlayer));
            PlayerMovementState.AddState(new MoveBehaviour(_MoveSpeed,this, _RigidbodyPlayer));
            PlayerMovementState.AddState(new RunBehaviour(_RunSpeed, this, _RigidbodyPlayer));

            PlayerMovementState.SetState<IdleBehaviour>();
        }
        public void UpdateDirection() {
            var MousePoision = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var Direction = MousePoision - _RigidbodyPlayer.transform.position;
            var Angles = Mathf.Atan2(Direction.y, Direction.x) * Mathf.Rad2Deg;

            _RigidbodyPlayer.transform.rotation = Quaternion.Euler(Direction.x, Direction.y, Angles);
        }
        public InputActionS GetInputActionS() => _InputPlayer;


    }
}