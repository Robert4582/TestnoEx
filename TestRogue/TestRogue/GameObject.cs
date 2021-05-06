using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public class GameObject : Composite
    {
        bool hasActed = false;

        public Position position;

        public bool IsActive;

        public void SetToHasActed()
        {
            hasActed = true;
        }

        public bool ConsumeAction()
        {
            if (hasActed)
            {
                hasActed = false;
                return true;
            }
            return false;
        }

        public GameObject(string spriteName, bool isActive = false) : base()
        {
            IsActive = isActive;

            this.position = new Position();
            AddComponent(new Renderer(spriteName));
        }

        public GameObject(Position position, string spriteName, bool isActive = false) : base()
        {
            IsActive = isActive;

            this.position = position;
            AddComponent(new Renderer(spriteName));
        }
    }
}
