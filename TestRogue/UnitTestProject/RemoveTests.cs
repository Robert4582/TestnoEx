using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void CanAddObjectToRemoveList()
        {
            //Arrange
            GameObject test = new GameObject("");

            //Act
            Game1.AddToRemoval(test);

            //Assert
            CollectionAssert.Contains(Game1.removedObjects, test);
        }

        [TestMethod]
        public void CanRemove()
        {
            //Arrange
            GameObject test = new GameObject("");
            Game1.gameObjects.Add(test);
            Game1.AddToRemoval(test);

            //Act
            Game1.RemoveFromList();

            //Assert
            CollectionAssert.DoesNotContain(Game1.gameObjects, test);
        }
    }
}
