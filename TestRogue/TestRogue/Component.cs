namespace TestRogue
{
    public abstract class Component
    {
        public Component owner { get => owner; set => owner = value; }

        public abstract void Start();

        public abstract void Update();

        public abstract void Draw();
    }
}
