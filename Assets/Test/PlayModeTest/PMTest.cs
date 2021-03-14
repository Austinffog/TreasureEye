using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PMTest
    {

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator Player_Health()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            float playerHealth = Player.health;
            var player = new GameObject();
            player.AddComponent<Player>();
            player.AddComponent<Rigidbody2D>();

            Assert.AreEqual(100f, playerHealth);
            yield return null;

        }
    }
}
