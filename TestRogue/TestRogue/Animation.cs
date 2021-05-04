using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TestRogue
{
    public class Animation : Component
    {
        Texture2D texture2D;
        string name;

        public Animation(string spriteName)
        {

            name = spriteName;

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //Example of how to draw
            //spriteBatch.Draw(sprite, position, color);

            Point pos = ((GameObject)owner).position;
            spriteBatch.Draw(texture2D, new Rectangle(pos, new Point(64,64)), new Rectangle(0, 0, 64, 64), Color.White);

        }

        public override void Start(ContentManager contentManager)
        {

            texture2D = contentManager.Load<Texture2D>(name);

        }

        public override void Update()
        {
            
        }
    }
}
