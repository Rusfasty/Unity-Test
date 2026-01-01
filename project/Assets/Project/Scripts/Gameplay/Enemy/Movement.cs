using System;
using UnityEngine;

namespace Scripts.Enemy {
    [Serializable]
    public class Movement {
        [SerializeField] private float _CurrentSpeed;
        [SerializeField] private float _RunSpeed;
        [SerializeField] private float _MoveSpeed;
        [SerializeField] private float _SteltzSpeed;
        [Space]
        [SerializeField] private Rigidbody2D _RigidbodyPlayer;

        public Movement(float MoveSpeed) {
            _MoveSpeed = MoveSpeed;
            _SteltzSpeed = MoveSpeed * (_SteltzSpeed + 0.4f);
            _RunSpeed = MoveSpeed * (_RunSpeed + 1.4f);
        }
    }
}