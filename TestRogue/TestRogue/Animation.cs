using Microsoft.Xna.Framework.Graphics;
using System;

namespace TestRogue
{
    public class Animation : Component
    {
        SpriteBatch spriteBatch;

        public override void Draw()
        {
            spriteBatch.Begin();

            //Example of how to draw
            //spriteBatch.Draw(sprite, position, color);

            spriteBatch.End();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Update(SpriteBatch spriteBatch)
        {
            
        }
    }
}
