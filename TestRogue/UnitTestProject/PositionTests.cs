using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
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
        public void CanSetPositionInt()
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
        public void CanOffsetPositionInt()
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
        public void CanOffsetNegativePositionInt()
        {
            //Arrange
            Position pos = new Position(5, 10);

            //Act
            pos.OffsetPosition(-10, -20);

            //Assert
            Assert.AreEqual(pos.X, -5);
            Assert.AreEqual(pos.Y, -10);

        }




        [TestMethod]
        public void CanSetPositionPos()
        {
            //Arrange
            Position pos = new Position(5, 10);
            Position newPos = new Position(10, 20);

            //Act
            pos.SetPosition(newPos);

            //Assert
            Assert.AreEqual(newPos, pos);
           
        }

        [TestMethod]
        public void CanOffsetPositionPos()
        {
            //Arrange
            Position pos = new Position(5, 10);
            Position newPos = new Position(10, 20);

            //Act
            pos.OffsetPosition(newPos);

            //Assert
            Assert.AreEqual(pos.X, 15);
            Assert.AreEqual(pos.Y, 30);
        }

        [TestMethod]
        public void CanOffsetNegativePositionPos()
        {
            //Arrange
            Position pos = new Position(5, 10);
            Position newPos = new Position(-10, -20);

            //Act
            pos.OffsetPosition(newPos);

            //Assert
            Assert.AreEqual(pos.X, -5);
            Assert.AreEqual(pos.Y, -10);
        }



        [TestMethod]
        public void CanReturnPoint()
        {
            //Arrange
            Position pos = new Position(0, 0);
            Point expectedPoint = new Point(0, 0);

            //Act
            Point point = pos;


            //Assert
            Assert.AreEqual(point, expectedPoint);
        }

    }
}
