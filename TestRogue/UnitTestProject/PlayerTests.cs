using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRogue;
using TestRogue.GameObjects;

namespace UnitTestProject
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void ContainsInputAndMovementComponents()
        {
            //Arrange
            Player player = new Player(new Position());

            //Act
            InputHandler input = player.GetComponent<InputHandler>();
            MovementHandler movement = player.GetComponent<MovementHandler>();

            //Assert
            Assert.IsNotNull(input);
            Assert.IsNotNull(movement);
        }
    }
}
