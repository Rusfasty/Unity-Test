using UnityEngine;

namespace Scripts.Player.MovementState {
    public abstract class MovementState : Architecture.State.State {
        protected float _MoveSpeed;
        protected Movement _Movement;
        protected Rigidbody2D _rigidbody2D;

        public override void Entry() { }
        public override void Update() { }
        public override void Exit() { }

        public MovementState(float MoveSpeed,Movement movementPlayer, Rigidbody2D PlayerRI) {
            _MoveSpeed = MoveSpeed;
            _Movement = movementPlayer;
            _rigidbody2D = PlayerRI;

        }
        protected void Move(Vector2 vector) {
            var InputAction = _Movement.GetInputActionS();
            _rigidbody2D.MovePosition(_rigidbody2D.position += vector * (_MoveSpeed * Time.deltaTime));
        }
    }
}