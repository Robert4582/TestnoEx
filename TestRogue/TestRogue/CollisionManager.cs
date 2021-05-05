using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public static class CollisionManager
    {
        public static List<GameObject> objects;

        public static List<GameObject> TestCollisions(GameObject sourceObj)
        {
            List<GameObject> collisions = new List<GameObject>();

            foreach (GameObject otherObj in objects)
            {
                if (sourceObj != otherObj)
                {
                    if (sourceObj.position.Equals(otherObj.position))
                    {
                        collisions.Add(otherObj);
                    }
                }
            }

            return collisions;
        }

        public static List<GameObject> TestCollisions(Position sourceObjPos)
        {
            List<GameObject> collisions = new List<GameObject>();

            foreach (GameObject otherObj in objects)
            {
                if (sourceObjPos.Equals(otherObj.position))
                {
                    collisions.Add(otherObj);
                }
            }

            return collisions;
        }
    }
}
