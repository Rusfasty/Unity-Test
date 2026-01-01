using UnityEngine;

namespace Scripts.Player.MovementState {
    public class RunBehaviour : MovementState {
        public RunBehaviour(float MoveSpeed, Movement movementPlayer, Rigidbody2D PlayerRI) : base(MoveSpeed, movementPlayer, PlayerRI) { }

        public override void Update() {
            var InputAction = _Movement.GetInputActionS();
            if (InputAction.Player.Run.ReadValue<float>() != 1) _Movement.PlayerMovementState.SetState<IdleBehaviour>();
            if (InputAction.Player.Movement.ReadValue<Vector2>() == Vector2.zero) _Movement.PlayerMovementState.SetState<IdleBehaviour>();

            Move(InputAction.Player.Movement.ReadValue<Vector2>());
        }

    }
}