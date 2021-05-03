using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class PositionTests
    {
        [TestMethod]
        public void CanEvaluateEqualPosition()
        {
            //Arrange
            Position a = new Position(0, 0);
            Position b = new Position(0, 0);

            //Assert
            Assert.IsTrue(a.Equals(b));
        }

        [TestMethod]
        public void CanEvaluateUnequalPosition()
        {
            //Arrange
            Position a = new Position(0, 0);
            Position b = new Position(5, 0);

            //Assert
            Assert.IsFalse(a.Equals(b));
        }

        [TestMethod]
        public void CanSetPosition()
        {
            //Arrange
            Position pos = new Position(5, 10);

            //Act
            pos.SetPosition(10, 20);

            //Assert
            Assert.AreEqual(pos.X, 10);
            Assert.AreEqual(pos.Y, 20);
        }

        [TestMethod]
        public void CanOffsetPosition()
        {
            //Arrange
            Position pos = new Position(5, 10);

            //Act
            pos.OffsetPosition(10, 20);

            //Assert
            Assert.AreEqual(pos.X, 15);
            Assert.AreEqual(pos.Y, 30);

        }

        [TestMethod]
        public void CanOffsetNegativePosition()
        {
            //Arrange
            Position pos = new Position(5, 10);

            //Act
            pos.OffsetPosition(-10, -20);

            //Assert
            Assert.AreEqual(pos.X, -5);
            Assert.AreEqual(pos.Y, -10);

        }
    }
}
