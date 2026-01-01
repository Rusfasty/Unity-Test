using System;
using UnityEngine;

namespace Scripts.Enemy {
    [Serializable]
    public class Health {
        [SerializeField] private float _CurrentHealth;
        [SerializeField] private float _MaxHealth;

        public void TakeDamage(float Count) {
            _CurrentHealth -= Count;
            if (_CurrentHealth <= 0) Death?.Invoke(); 
        }
        public void Heal(float count) { 
            _CurrentHealth += count;
            if (_CurrentHealth > _MaxHealth) _CurrentHealth = _MaxHealth;
        }
        public Health(float MaxHealth) {
            _CurrentHealth = MaxHealth;
            _MaxHealth = MaxHealth;
        }

        public float GetCurrentHealth => _CurrentHealth;
        public float GetMaxHealth => _MaxHealth;

        public event Action Death;
    }
}