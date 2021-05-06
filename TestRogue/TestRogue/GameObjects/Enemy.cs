using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue.GameObjects
{
    public class Enemy : GameObject
    {
        public Enemy(Position position) : base(position, "spritesheet_Walk_Mine", true)
        {
            AddComponent(new AIHandler());
            AddComponent(new Combatant());
            AddComponent(new MovementHandler());
        }
    }
}
