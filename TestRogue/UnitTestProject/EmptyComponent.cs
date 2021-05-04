using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRogue;

namespace UnitTestProject
{
    public class EmptyComponent : Component
    {
        public bool hasRunStart = false;
        public bool hasRunUpdate = false;
        public bool hasRunDraw = false;

        public override void Start(ContentManager contentManager)
        {
            hasRunStart = true;
        }

        public override void Update()
        {
            hasRunUpdate = true;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            hasRunDraw = true;
        }
    }
}
