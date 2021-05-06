using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRogue;
using TestRogue.GameObjects;

namespace UnitTestProject
{
    [TestClass]
    public class EnemyTests
    {
        [TestMethod]
        public void ContainsInputComponents()
        {
            //Arrange
            Enemy enemy = new Enemy(new Position());

            //Act
            InputHandler input = enemy.GetComponent<InputHandler>();

            //Assert
            Assert.IsNotNull(input);
        }
    }
}
