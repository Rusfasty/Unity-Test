using UnityEngine;

namespace Scripts.Player {
    public class Player : MonoBehaviour {
        [Header("Properties")]
        [SerializeField] private Health _Health;
        [SerializeField] private Movement _Movement;
        [SerializeField] private Inventory _inventor;
        [Header("Components")]
        [SerializeField] private Rigidbody2D _RigidbodyPlayer;
        [Header("Coefficient")]
        [SerializeField] private float _CreationMovement;
        [SerializeField] private float _CreationHealth;

        private Script.Input.InputActionS InputPlayer;
        public void Update() {
            _Movement?.UpdataMove();
        }

        public void Init() {
            InputPlayer = new Script.Input.InputActionS();
            _Health = new Health(_CreationHealth);
            _Movement = new Movement(_CreationMovement, InputPlayer, _RigidbodyPlayer);
        }

        public void Awake() => Init();

        public void OnEnable() => InputPlayer.Enable();
        public void OnDisable() => InputPlayer.Disable();
    }
}