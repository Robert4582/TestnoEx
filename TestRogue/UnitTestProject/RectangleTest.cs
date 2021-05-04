using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class RectangleTest
    {

        [TestMethod]
        public void IsPositionCorrectlyConverted()
        {

            //Arrange
            Composite owner = new GameObject(new Position(5, 1), "");
            Renderer spriteRectange = new Renderer("");
            owner.AddComponent(spriteRectange);
            Rectangle test = new Rectangle(320, 64, 64, 64);

            //Act
            Rectangle spriteTest = spriteRectange.SpriteRectangle();

            //Assert
            Assert.AreEqual(spriteTest, test);
            
        }

        [TestMethod]
        public void IsPositionCorrectlyConvertedWherePositionIsNegativNumbers()
        {

            //Arrange
            Composite owner = new GameObject(new Position(-1, -1), "");
            Renderer spriteRectange = new Renderer("");
            owner.AddComponent(spriteRectange);
            Rectangle test = new Rectangle(-64, -64, 64, 64);

            //Act
            Rectangle spriteTest = spriteRectange.SpriteRectangle();

            //Assert
            Assert.AreEqual(spriteTest, test);

        }

        [TestMethod]
        public void IsSourceRectCorrectlyConverted()
        {

            //Arrange
            Renderer spriteRectange = new Renderer("");

            Rectangle test = new Rectangle(0, 0, 64, 64);

            //Act
            Rectangle spriteTest = spriteRectange.sourceRectangle();

            //Assert
            Assert.AreEqual(spriteTest, test);

        }

    }
}
