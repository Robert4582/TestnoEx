using Microsoft.VisualStudio.TestTools.UnitTesting;

using TestRogue;
using TestRogue.GameObjects;

using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class AITests
    {
        [TestMethod]
        public void CanSetTarget()
        {
            //Arrange
            Player player = new Player(new Position(10, 10));
            AIHandler aIHandler = new AIHandler();
            Game1.gameObjects = new List<GameObject>() { player};

            //Act
            aIHandler.SetTargetPosition();

            //Assert
            Assert.IsTrue(aIHandler.targetPosition.Equals(new Position(10, 10)));
        }

        [TestMethod]
        public void CanDrawPath()
        {
            //Arrange
            GameObject gameObject = new GameObject("");
            Player player = new Player(new Position(0, 3));
            AIHandler aIHandler = new AIHandler();
            gameObject.AddComponent(aIHandler);
            Game1.gameObjects = new List<GameObject>() { player };
            aIHandler.SetTargetPosition();
            List<Position> expectedPositions = new List<Position>() { new Position(0, 1), new Position(0, 2), new Position(0, 3) };

            //Act
            List<Position> actualPositions = aIHandler.DrawPath();

            //Assert
            CollectionAssert.AreEqual(expectedPositions, actualPositions);
        }

        [TestMethod]
        public void CanReadAiInput()
        {
            //Arrange
            GameObject gameObject = new GameObject("");
            AIHandler input = new AIHandler();
            gameObject.AddComponent(input);


            //Act
            input.HandleAiInput(new Position(0, 1));

            //Assert
            Assert.AreEqual(Actions.Down, input.CurrentAction);
        }

        [TestMethod]
        public void CanHandleNoPlayer()
        {
            //Arrange
            Enemy enemy = new Enemy(new Position(69, 69));
            AIHandler aIHandler = new AIHandler();
            Game1.gameObjects = new List<GameObject>() { enemy };

            //Act
            aIHandler.SetTargetPosition();

            //Assert
            Assert.IsTrue(aIHandler.targetPosition.Equals(new Position(69, 69)));

        }

        [TestMethod]
        public void CanHandleNoPlayerOrEnemy()
        {
            //Arrange
            AIHandler aIHandler = new AIHandler();
            GameObject gameObject = new GameObject("");
            gameObject.AddComponent(aIHandler);
            Game1.gameObjects = new List<GameObject>() { gameObject };

            //Act
            aIHandler.SetTargetPosition();

            //Assert
            Assert.IsTrue(gameObject.position.Equals(aIHandler.targetPosition));

        }
    }
}
