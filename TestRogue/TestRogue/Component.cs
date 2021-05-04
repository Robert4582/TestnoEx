using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TestRogue
{
    public abstract class Component
    {
        private Component owner = null;

        public Component Owner { get => owner; set => owner = value; }

        public abstract void Start(ContentManager contentManager);

        public abstract void Update();

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
