using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestRogue;

namespace UnitTestProject
{
    [TestClass]
    public class CombatTest
    {

        [TestMethod]
        public void TestCombatantTakeDMG()
        {

            //Arrange
            Combatant battle = new Combatant();
            int playerHP = 50;
            int playerDMG = 25;
            int hP = playerHP - playerDMG;

            //Act
            battle.TakeDMG(battle.dmgGiven);

            //Assert
            Assert.AreEqual(battle.health, hP);

        }

        [TestMethod]
        public void TestCombatantGiveDMG()
        {

            //Arrange
            Combatant battle = new Combatant();
            GameObject enemy = new GameObject("", true);
            enemy.AddComponent(battle);
            int playerHP = 50;
            int playerDMG = 25;
            int hP = playerHP - playerDMG;

            //Act
            battle.GiveDMG(enemy);

            //Assert
            Assert.AreEqual(battle.health, hP);

        }

    }

}
