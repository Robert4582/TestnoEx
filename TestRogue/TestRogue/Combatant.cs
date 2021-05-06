using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRogue
{
    public class Combatant : Component
    {

        public int health = 50;
        public int dmgGiven = 50;

        public bool IsDead
        {
            get => health <= 0;
        }

        public InputHandler handler;

        public void TakeDMG(int DMG)
        {

            health -= DMG;

            if (IsDead)
            {
                Game1.gameObjects.Remove((GameObject)Owner);
            }

        }

        public void GiveDMG(GameObject gameObject)
        {

            Combatant combatant = gameObject.GetComponent<Combatant>();

            if (combatant != null)
            {
                combatant.TakeDMG(dmgGiven);
            }

        }

        public List<GameObject> SearchOpponents(Actions action)
        {

            List<GameObject> colliding = new List<GameObject>();

            switch (action)
            {
                case Actions.Up:
                    colliding = CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(0, -1));
                    break;
                case Actions.Down:
                    colliding = CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(0, 1));
                    break;
                case Actions.Left:
                    colliding = CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(-1, 0));
                    break;
                case Actions.Right:
                    colliding = CollisionManager.TestCollisions(((GameObject)Owner).position + new Position(1, 0));
                    break;
                case Actions.None:
                    break;
                default:
                    break;

            }

            return colliding;
        }

        public override void Start(ContentManager contentManager)
        {
            handler = ((Composite)Owner).GetComponent<InputHandler>();
        }

        public override void Update()
        {
            if (handler != null)
            {
                foreach (GameObject gameObject in SearchOpponents(handler.CurrentAction))
                {
                    GiveDMG(gameObject);
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        { }

    }

}
