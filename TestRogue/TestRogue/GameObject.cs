using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public class GameObject : Composite
    {
        public Position position;

        public GameObject(Position position, string spriteName) : base()
        {
            this.position = position;
            AddComponent(new Renderer(spriteName));
        }
    }
}
