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
    }
}
