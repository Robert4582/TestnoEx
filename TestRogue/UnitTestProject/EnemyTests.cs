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
            MovementHandler movement = enemy.GetComponent<MovementHandler>();

            //Assert
            Assert.IsNotNull(input);
            Assert.IsNotNull(movement);
        }
    }
}
