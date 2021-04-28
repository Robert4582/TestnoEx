namespace TestRogue
{
    public abstract class Component
    {
        public Component owner { get => owner; }

        public abstract void Start();

        public abstract void Update();

        public abstract void Draw();
    }
}
