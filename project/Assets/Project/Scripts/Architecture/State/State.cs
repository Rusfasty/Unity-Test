namespace Scripts.Architecture.State {
    public abstract class State {
        public abstract void Update();
        public abstract void Exit();
        public abstract void Entry();
    }
}