using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class ComponentTests
    {

        [TestMethod]
        public void CanAddComponent()
        {
            //Arrange
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);

            //Assert
            Assert.AreEqual(holder.GetComponent<EmptyComponent>(), c);
        }

        [TestMethod]
        public void CanSetComponentOwner()
        {
            //Arrange
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);

            //Assert
            Assert.AreEqual(c.Owner, holder);
        }

        [TestMethod]
        public void CanRemoveComponent()
        {
            //Arrange
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);
            holder.RemoveComponent(c);

            //Assert
            Assert.AreEqual(holder.GetComponent<EmptyComponent>(), default(EmptyComponent));
        }

        [TestMethod]
        public void CanAccessComponent()
        {
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);

            //Assert
            Assert.AreEqual(holder.GetComponent<EmptyComponent>(), c);

        }

        [TestMethod]
        public void CanRunStart()
        {
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);
            holder.Start(null);

            //Assert
            Assert.IsTrue(c.hasRunStart);

        }

        [TestMethod]
        public void CanRunUpdate()
        {
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);
            holder.Update();

            //Assert
            Assert.IsTrue(c.hasRunUpdate);
        }

        [TestMethod]
        public void CanRunDraw()
        {
            Composite holder = new Composite();
            EmptyComponent c = new EmptyComponent();

            //Act
            holder.AddComponent(c);
            holder.Draw(null);

            //Assert
            Assert.IsTrue(c.hasRunDraw);
        }

    }
}
