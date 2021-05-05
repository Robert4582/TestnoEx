using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class CombatTest
    {

        [TestMethod]
        public void CanPlayerLossHP()
        {

            //Arrange
            Combat battle = new Combat();
            int playerDMG = 25;
            int playerHP = 50;
            int newHP = playerHP - playerDMG;

            //Act
            int hp = battle.DMGPlayer();

            //Assert
            Assert.AreEqual(hp, newHP);

        }

        [TestMethod]
        public void CanDie()
        {

            //Arrange
            Combat battle = new Combat();
            bool isAlive = false;
            

            //Act
            bool died = battle.PlayerDied();

            //Assert
            Assert.AreEqual(died, isAlive);

        }
    }
}
