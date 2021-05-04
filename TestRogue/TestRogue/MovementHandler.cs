using Microsoft.Xna.Framework;
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
      
        
        public override void Draw()
        {
            
        }

        public override void Start()
        {
            handler = ((GameObject)owner).GetComponent<InputHandler>();
        }

        public override void Update()
        {
            switch (handler.CurrentAction)
            {
                case Actions.Up:
                    ((GameObject)owner).position.OffsetPosition(0, 1);
                    break;
                case Actions.Down:
                    ((GameObject)owner).position.OffsetPosition(0, -1);
                    break;
                case Actions.Left:
                    ((GameObject)owner).position.OffsetPosition(-1, 0);
                    break;
                case Actions.Right:
                    ((GameObject)owner).position.OffsetPosition(1, 0);
                    break;
                case Actions.None:
                    break;
                default:
                    break;
            }

        }
    }
}
