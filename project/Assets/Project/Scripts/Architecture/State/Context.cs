using System;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Architecture.State {
    public class Context {
        protected State CurrentState;

        protected Dictionary<Type, State> StateDictionary;

        public Context() => StateDictionary = new Dictionary<Type, State>();

        public void Update() => CurrentState?.Update();

        public void AddState<T>(T State) where T : State {
            var Type = typeof(T);
            if (!StateDictionary.ContainsKey(Type))
                StateDictionary.Add(Type, State);
            else Debug.LogError($"“ип {Type} уже зарегистрирован в StateDictionary. регистраци€ невозможно!" );
        }
        public void RemoveState<T>(T state) where T : State {}
        public void SetState<T>() where T : State {
            var Type = typeof(T);
            if (CurrentState != null && CurrentState.GetType() == Type) return;
            if (StateDictionary.TryGetValue(Type, out var NewState)) {
                CurrentState?.Exit();
                CurrentState = NewState;
                CurrentState.Entry();
            }
        }

    }
}