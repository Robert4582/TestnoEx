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
        public InputHandler handler;
      
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public override void Start(ContentManager contentManager)
        {
            handler = ((Composite)Owner).GetComponent<InputHandler>();
        }

        public override void Update()
        {
            ActionSwitch(handler.CurrentAction);

        }

        public void ActionSwitch(Actions action)
        {
            switch (action)
            {
                case Actions.Up:
                    if (CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(0, -1)).Count == 0)
                    {
                        ((GameObject)Owner).position.OffsetPosition(0, -1);
                    }
                    break;
                case Actions.Down:
                    if (CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(0, 1)).Count == 0)
                    {
                        ((GameObject)Owner).position.OffsetPosition(0, 1);
                    }
                    break;
                case Actions.Left:
                    if (CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(-1, 0)).Count == 0)
                    {
                        ((GameObject)Owner).position.OffsetPosition(-1, 0);
                    }
                    break;
                case Actions.Right:
                    if (CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(1, 0)).Count == 0)
                    {
                        ((GameObject)Owner).position.OffsetPosition(1, 0);
                    }
                    break;
                case Actions.None:
                    break;
                default:
                    break;
            }
        }
    }
}
