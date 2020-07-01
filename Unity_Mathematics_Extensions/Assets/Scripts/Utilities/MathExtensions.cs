using System;
using UnityEngine;

namespace Utilities
{
    public static class MathExtensions
    {
        /// <summary>
        /// Returns a clamped value between min and max
        /// </summary>
        /// <param name="val">Current value</param>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <typeparam name="T">An IComparable type</typeparam>
        /// <returns>Clamped value between min and max</returns>
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            if (val.CompareTo(min) < 0) return min;
            else if (val.CompareTo(max) > 0) return max;
            else return val;
        }

        /// <summary>
        /// Returns true if two vectors are almost equal, given a precision 
        /// </summary>
        /// <param name="v1">First vector</param>
        /// <param name="v2">Second vector</param>
        /// <param name="precision">Precision when comparing</param>
        /// <returns></returns>
        public static bool AlmostEqual(Vector3 v1, Vector3 v2, float precision)
        {
            bool equal = true;

            if (Mathf.Abs(v1.x - v2.x) > precision) equal = false;
            if (Mathf.Abs(v1.y - v2.y) > precision) equal = false;
            if (Mathf.Abs(v1.z - v2.z) > precision) equal = false;

            return equal;
        }
    }
}