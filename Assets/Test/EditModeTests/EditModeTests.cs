using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class EditModeTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Player_Speed()
        {
            // Use the Assert class to test conditions

            //Act
            float speed = Player.MovementSpeed(3f);
            //Assert
            Assert.AreEqual(3f, speed);
        }
        
        [Test]
        public void Poison_Amount()
        {
            //Act
            int poisonAmount = Player.Poison(2);
            //Assert
            Assert.AreEqual(2, poisonAmount);
        }

    }
}
