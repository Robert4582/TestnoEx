using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public enum Actions
    {
        Up,
        Down, 
        Left,
        Right,
        None
    }

    public class InputHandler : Component
    {
        Actions currentAction = Actions.None;

        public Actions CurrentAction { get => currentAction; }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public override void Start(ContentManager contentManager)
        {
            
        }

        public override void Update()
        {
            // Poll for current keyboard state
            HandleInput(Keyboard.GetState());
        }

        public void HandleInput(KeyboardState state)
        {
            if (state.IsKeyDown(Keys.W))
            {
                currentAction = Actions.Up;
            }

            else if (state.IsKeyDown(Keys.S))
            {
                currentAction = Actions.Down;
            }

            else if (state.IsKeyDown(Keys.A))
            {
                currentAction = Actions.Left;
            }

            else if (state.IsKeyDown(Keys.D))
            {
                currentAction = Actions.Right;
            }

            else
            {
                currentAction = Actions.None;
            }
        }
    }
}
