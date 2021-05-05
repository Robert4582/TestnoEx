using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class GameObjectTests
    {

        [TestMethod]
        public void ContainsRenderer()
        {
            //Arrange
            GameObject gameObject = new GameObject(new Position(),"");

            //Act
            Renderer renderer = gameObject.GetComponent<Renderer>();

            //Assert
            Assert.IsNotNull(renderer);
        }

        [TestMethod]
        public void CanDifferentiateActive()
        {
            //Arrange
            GameObject inactiveGo = new GameObject("", false);
            GameObject activeGo = new GameObject("", true);

            //Assert
            Assert.AreNotEqual(inactiveGo.IsActive, activeGo.IsActive);
        }

        [TestMethod]
        public void CanSetHasActed()
        {
            //Arrange
            GameObject activeGo = new GameObject("", true);

            //Act
            activeGo.SetToHasActed();

            //Assert
            Assert.IsTrue(activeGo.ConsumeAction());
        }

        [TestMethod]
        public void ConsumesActionUponCheck()
        {
            //Arrange
            GameObject activeGo = new GameObject("", true);

            //Act
            activeGo.SetToHasActed();
            activeGo.ConsumeAction();

            //Assert
            Assert.IsFalse(activeGo.ConsumeAction());
        }
    }
}
