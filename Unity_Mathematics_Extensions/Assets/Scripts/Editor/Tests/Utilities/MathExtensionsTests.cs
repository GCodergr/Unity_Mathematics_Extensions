using NUnit.Framework;
using Utilities;
using UnityEngine;

namespace Tests.Utilities
{
    public class _0_Math_Extensions_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(7, 5, 10, 7)]
        [TestCase(-5, 5, 10, 5)]
        [TestCase(5, 5, 10, 5)]
        [TestCase(15, 5, 10, 10)]
        [TestCase(10, 5, 10, 10)]
        public void _0_Clamp(int initial, int min, int max, int expected)
        {
            //given 
            //when
            var actual = initial.Clamp(min, max);
            //then
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void _1_Almost_Equal_Is_True()
        {
            //given 
            Vector3 v1 = new Vector3(1f, 1f, 1f);
            Vector3 v2 = new Vector3(1.006f, 1.002f, 1.005f);
            float precision = 0.01f;
            //when
            var result = MathExtensions.AlmostEqual(v1, v2, precision);
            //then
            Assert.IsTrue(result);
        }
        
        [Test]
        public void _2_Almost_Equal_Is_False()
        {
            //given 
            Vector3 v1 = new Vector3(1f, 1f, 1f);
            Vector3 v2 = new Vector3(1.03f, 1.009f, 1.005f);
            float precision = 0.01f;
            //when
            var result = MathExtensions.AlmostEqual(v1, v2, precision);
            //then
            Assert.IsFalse(result);
        }

        [TearDown]
        public void TestEnd()
        {
        }
    }
}
