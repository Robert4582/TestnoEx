using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class TurnManagerTests
    {
        [TestMethod]
        public void CanChangeTurn()
        {
            //Arrange
            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new GameObject(""));
            gameObjects.Add(new GameObject(""));
            gameObjects.Add(new GameObject(""));

            TurnManager.Actors = gameObjects.Count;

            //Act
            //Assert
            Assert.AreEqual(TurnManager.CurrentActor, 0);
            TurnManager.NextTurn();
            Assert.AreEqual(TurnManager.CurrentActor, 1);
            TurnManager.NextTurn();
            Assert.AreEqual(TurnManager.CurrentActor, 2);
            TurnManager.NextTurn();
            Assert.AreEqual(TurnManager.CurrentActor, 0);
            TurnManager.NextTurn();
        }


        [TestMethod]
        public void CanHandleChangingObjects()
        {
            //Arrange
            TurnManager.Clear();

            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new GameObject("0"));
            gameObjects.Add(new GameObject("1"));
            GameObject toBeRemoved = new GameObject("2");
            gameObjects.Add(toBeRemoved);

            TurnManager.Actors = gameObjects.Count;

            //Act
            //Assert
            Assert.AreEqual(0, TurnManager.CurrentActor);
            TurnManager.NextTurn();
            Assert.AreEqual(1, TurnManager.CurrentActor);
            gameObjects.Remove(toBeRemoved);
            TurnManager.Actors = gameObjects.Count;
            TurnManager.NextTurn();
            Assert.AreEqual(0, TurnManager.CurrentActor);
            TurnManager.NextTurn();
        }
        [TestMethod]
        public void CanHandleTwoChangingObjects()
        {
            //Arrange
            TurnManager.Clear();

            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(new GameObject("0"));
            GameObject toBeRemoved = new GameObject("1");
            GameObject toBeRemoved2 = new GameObject("2");
            gameObjects.Add(toBeRemoved);
            gameObjects.Add(toBeRemoved2);

            TurnManager.Actors = gameObjects.Count;

            //Act
            //Assert
            Assert.AreEqual(TurnManager.CurrentActor, 0);
            gameObjects.Remove(toBeRemoved);
            gameObjects.Remove(toBeRemoved2);
            TurnManager.Actors = gameObjects.Count;
            TurnManager.NextTurn();
            Assert.AreEqual(TurnManager.CurrentActor, 0);
            TurnManager.NextTurn();
        }
    }
}
