using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Linq;
using System.Collections.Generic;
using TestRogue.GameObjects;

namespace TestRogue
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static int TileSize = 64;

        public static List<GameObject> gameObjects = new List<GameObject>();

        public static List<GameObject> removedObjects = new List<GameObject>();

        public static void AddToRemoval(GameObject gameObject)
        {
            removedObjects.Add(gameObject);
        }

        public static void RemoveFromList()
        {
            foreach (var item in removedObjects)
            {
                gameObjects.Remove(item);
            }
            removedObjects.Clear();
        }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            IsFixedTimeStep = true;
            TargetElapsedTime = new TimeSpan(1000000);
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameObjects.Add(new Player(new Position(10, 10)));

            gameObjects.Add(new Enemy(new Position(10, 9)));
            gameObjects.Add(new Enemy(new Position(3, 5)));
            gameObjects.Add(new Enemy(new Position(5, 3)));
            gameObjects.Add(new Enemy(new Position(7, 9)));
            gameObjects.Add(new Enemy(new Position(10, 3)));
            gameObjects.Add(new Enemy(new Position(6, 7)));
            gameObjects.Add(new Enemy(new Position(1, 4)));
            gameObjects.Add(new Enemy(new Position(5, 2)));
            gameObjects.Add(new Enemy(new Position(1, 9)));

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Start(this.Content);
            }
        }

        protected override void Update(GameTime gameTime)
        {
            CollisionManager.objects = gameObjects;
            List<GameObject> activeObjects = gameObjects.Where(x => x.IsActive).ToList();

            if (activeObjects.Count > 0)
            {
                TurnManager.Actors = activeObjects.Count;

                GameObject curr = activeObjects[TurnManager.CurrentActor];
                curr.Update();

                RemoveFromList();

                TurnManager.Actors = gameObjects.Where(x => x.IsActive).ToList().Count;

                if (curr.ConsumeAction())
                {
                    TurnManager.NextTurn();
                }
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            
            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Draw(_spriteBatch);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
