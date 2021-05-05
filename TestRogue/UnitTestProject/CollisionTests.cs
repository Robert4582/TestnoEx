using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class CollisionTests
    {
        [TestMethod]
        public void CanDetectCollisionUsingGameObject()
        {
            //Arrange
            List<GameObject> objects = new List<GameObject>();

            GameObject player = new GameObject(new Position(10, 10), "");
            GameObject enemy = new GameObject(new Position(10, 10), "");

            objects.Add(player);
            objects.Add(enemy);

            CollisionManager.objects = objects;

            //Act
            List<GameObject> collisions = CollisionManager.TestCollisions(player);

            //Assert
            CollectionAssert.Contains(collisions, enemy);
        }

        [TestMethod]
        public void CanIgnoreSelfCollisionUsingGameObject()
        {
            //Arrange
            List<GameObject> objects = new List<GameObject>();

            GameObject player = new GameObject(new Position(10, 10), "");
            GameObject enemy = new GameObject(new Position(10, 10), "");

            objects.Add(player);
            objects.Add(enemy);

            CollisionManager.objects = objects;

            //Act
            List<GameObject> collisions = CollisionManager.TestCollisions(player);

            //Assert
            CollectionAssert.DoesNotContain(collisions, player);
        }

        [TestMethod]
        public void CanHandleNoCollidersUsingGameObject()
        {
            //Arrange
            List<GameObject> objects = new List<GameObject>();

            GameObject player = new GameObject(new Position(10, 10), "");

            objects.Add(player);

            CollisionManager.objects = objects;

            //Act
            List<GameObject> collisions = CollisionManager.TestCollisions(player);

            //Assert
            CollectionAssert.AreEqual(new List<GameObject>(), collisions);
        }

        [TestMethod]
        public void CanDetectCollisionUsingPosition()
        {
            //Arrange
            List<GameObject> objects = new List<GameObject>();

            GameObject player = new GameObject(new Position(10, 10), "");
            GameObject enemy = new GameObject(new Position(10, 10), "");

            objects.Add(player);
            objects.Add(enemy);

            CollisionManager.objects = objects;

            //Act
            List<GameObject> collisions = CollisionManager.TestCollisions(new Position(10,10));

            //Assert
            CollectionAssert.AreEqual(collisions, objects);
        }

        [TestMethod]
        public void CanHandleNoCollidersUsingPosition()
        {
            //Arrange
            List<GameObject> objects = new List<GameObject>();

            CollisionManager.objects = objects;

            //Act
            List<GameObject> collisions = CollisionManager.TestCollisions(new Position());

            //Assert
            CollectionAssert.AreEqual(new List<GameObject>(), collisions);
        }

    }
}
