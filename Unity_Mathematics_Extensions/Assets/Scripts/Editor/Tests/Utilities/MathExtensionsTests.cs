using UnityEngine;
using NUnit.Framework;
using Utilities;

namespace Tests.Utilities
{
    public class _0_Math_Extensions_Tests
    { 
	    [TestCase(7, 5, 10, 7)]
        [TestCase(-5, 5, 10, 5)]
        [TestCase(5, 5, 10, 5)]
        [TestCase(15, 5, 10, 10)]
        [TestCase(10, 5, 10, 10)]
        public void _0_Clamp(int initial, int min, int max, int expected)
        {
			// Act
            var actual = initial.Clamp(min, max);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void _1_Almost_Equal_Is_True()
        {
            // Arrange 
            Vector3 v1 = new Vector3(1f, 1f, 1f);
            Vector3 v2 = new Vector3(1.006f, 1.002f, 1.005f);
            float precision = 0.01f;
            // Act
            var result = MathExtensions.AlmostEqual(v1, v2, precision);
            // Assert
            Assert.IsTrue(result);
        }
        
        [Test]
        public void _2_Almost_Equal_Is_False()
        {
            // Arrange 
            Vector3 v1 = new Vector3(1f, 1f, 1f);
            Vector3 v2 = new Vector3(1.03f, 1.009f, 1.005f);
            float precision = 0.01f;
            // Act
            var result = MathExtensions.AlmostEqual(v1, v2, precision);
            // Assert
            Assert.IsFalse(result);
        }
    }
}
