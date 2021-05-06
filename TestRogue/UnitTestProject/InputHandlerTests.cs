using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework.Input;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void CanReadInput()
        {
            //Arrange
            GameObject gameObject = new GameObject("");
            InputHandler input = new InputHandler();
            KeyboardState state = new KeyboardState(Keys.W);
            gameObject.AddComponent(input);

            //Act
            input.HandleInput(state);

            //Assert
            Assert.AreEqual(Actions.Up, input.CurrentAction);
        }

        [TestMethod]
        public void CanReadNoInput()
        {
            //Arrange
            InputHandler input = new InputHandler();
            KeyboardState state = new KeyboardState();

            //Act
            input.HandleInput(state);

            //Assert
            Assert.AreEqual(Actions.None, input.CurrentAction);
        }
    }
}
