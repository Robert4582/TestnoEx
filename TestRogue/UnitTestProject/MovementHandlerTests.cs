using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class MovementHandlerTests
    {
        [TestMethod]
        public void CanOffsetPlayerPositionThroughCurrentActionDown()
        {
            //Arrange
            MovementHandler movement = new MovementHandler();
            GameObject obj = new GameObject(new Position(), "");
            obj.AddComponent(movement);

            //Act
            movement.ActionSwitch(Actions.Down);

            //Assert
            Assert.AreEqual(new Position(0, -1), obj.position);
        }

        [TestMethod]
        public void CanOffsetPlayerPositionThroughCurrentActionUp()
        {
            //Arrange
            MovementHandler movement = new MovementHandler();
            GameObject obj = new GameObject(new Position(), "");
            obj.AddComponent(movement);

            //Act
            movement.ActionSwitch(Actions.Up);

            //Assert
            Assert.AreEqual(new Position(0, 1), obj.position);
        }

        public void CanOffsetPlayerPositionThroughCurrentActionLeft()
        {
            //Arrange
            MovementHandler movement = new MovementHandler();
            GameObject obj = new GameObject(new Position(), "");
            obj.AddComponent(movement);

            //Act
            movement.ActionSwitch(Actions.Left);

            //Assert
            Assert.AreEqual(new Position(-1, 0), obj.position);
        }

        public void CanOffsetPlayerPositionThroughCurrentActionRight()
        {
            //Arrange
            MovementHandler movement = new MovementHandler();
            GameObject obj = new GameObject(new Position(), "");
            obj.AddComponent(movement);

            //Act
            movement.ActionSwitch(Actions.Right);

            //Assert
            Assert.AreEqual(new Position(1, 0), obj.position);
        }


        [TestMethod]
        public void CanRetrieveInputHandler()
        {
            //Arrange
            GameObject obj = new GameObject(new Position(), "");
            MovementHandler handler = new MovementHandler();
            InputHandler inputHandler = new InputHandler();
            obj.AddComponent(handler);
            obj.AddComponent(inputHandler);

            //Act
            obj.Start(null);

            //Assert
            Assert.AreSame(inputHandler, handler.handler);
        }
    }
}
