using UnityEngine;

namespace Scripts.Player.MovementState {
    public class IdleBehaviour : MovementState
    {
        public IdleBehaviour(float MoveSpeed, Movement movementPlayer, Rigidbody2D PlayerRI) : base(MoveSpeed, movementPlayer, PlayerRI) { }

        public override void Update() {
            var InputAction = _Movement.GetInputActionS();
            if (InputAction.Player.Movement.ReadValue<Vector2>() != Vector2.zero) _Movement.PlayerMovementState.SetState<MoveBehaviour>();
            _Movement.UpdateDirection();
        }
    }
}