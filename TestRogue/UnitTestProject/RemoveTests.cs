using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class RemoveTests
    {
        [TestMethod]
        public void CanRemoveGameObject()
        {

            GameObject gameObject = new GameObject("");

            List<GameObject> gameObjects = new List<GameObject>() { gameObject};

            Game1.RemoveObject(gameObject);



        }
    }
}
