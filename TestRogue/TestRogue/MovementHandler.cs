using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestRogue
{
    public class MovementHandler : Component
    {
        InputHandler handler;
      
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public override void Start(ContentManager contentManager)
        {
            handler = ((GameObject)Owner).GetComponent<InputHandler>();
        }

        public override void Update()
        {
            switch (handler.CurrentAction)
            {
                case Actions.Up:
                    ((GameObject)Owner).position.OffsetPosition(0, 1);
                    break;
                case Actions.Down:
                    ((GameObject)Owner).position.OffsetPosition(0, -1);
                    break;
                case Actions.Left:
                    ((GameObject)Owner).position.OffsetPosition(-1, 0);
                    break;
                case Actions.Right:
                    ((GameObject)Owner).position.OffsetPosition(1, 0);
                    break;
                case Actions.None:
                    break;
                default:
                    break;
            }

        }
    }
}
