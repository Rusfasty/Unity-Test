using UnityEngine;

namespace Scripts.Enemy {
    public abstract class Enemy : MonoBehaviour {
        [Header("Components")]
        [SerializeField] private Health _Health;
        [SerializeField] private Movement _Movement;

        public virtual void Inti()
        {
            _Health = new Health(15);
            _Movement = new Movement(7);
        }

        public void Awake() => Inti();
    }
}