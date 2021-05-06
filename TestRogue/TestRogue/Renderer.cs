using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TestRogue
{
    public class Renderer : Component
    {
        Texture2D texture2D;
        string name;

        public Color color = Color.White;

        public Renderer(string spriteName)
        {
            name = spriteName;

        }

        public Renderer(string spriteName, Color color)
        {
            name = spriteName;
            this.color = color;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //Example of how to draw
            //spriteBatch.Draw(sprite, position, color);

            spriteBatch.Draw(texture2D, SpriteRectangle(), sourceRectangle(), color);
        }

        public override void Start(ContentManager contentManager)
        {

            texture2D = contentManager.Load<Texture2D>(name);

        }

        public override void Update()
        { }

        public Rectangle SpriteRectangle()
        {

            Point posPoint = ((GameObject)Owner).position * Game1.TileSize;
            Point posSize = new Point(Game1.TileSize, Game1.TileSize);

            return new Rectangle(posPoint, posSize);

        }

        public Rectangle sourceRectangle()
        {

            return new Rectangle(0, 0, Game1.TileSize, Game1.TileSize);

        }
    }
}
