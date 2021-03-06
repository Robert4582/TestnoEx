using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue.GameObjects
{
    public class Player : GameObject
    {
        public Player(Position position) : base(position,"spritesheet_Walk_Mine", true)
        {
            AddComponent(new InputHandler());
            AddComponent(new Combatant());
            AddComponent(new MovementHandler());
        }
    }
}
