using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace TestRogue
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public static int TileSize = 64;

        List<GameObject> gameObjects = new List<GameObject>();


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
            CollisionManager.objects = gameObjects;
            GameObject player = new GameObject(new Position(10, 10), "spritesheet_Walk_Mine");
            player.AddComponent(new InputHandler());
            player.AddComponent(new MovementHandler());
            gameObjects.Add(player);

            gameObjects.Add(new GameObject(new Position(5,5), "spritesheet_Walk_Mine"));

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
            // TODO: Add your update logic here

            foreach (GameObject gameObject in gameObjects)
            {
                gameObject.Update();
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
