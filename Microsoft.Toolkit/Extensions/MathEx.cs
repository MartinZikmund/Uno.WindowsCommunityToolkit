using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.Toolkit.Extensions
{
    /// <summary>
	/// Compatibility for System.Math.Clamp for netstandard2.0
	/// </summary>
    public static class MathEx
    {
        /// <summary>
		/// Clamps a value
		/// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Clamp(double value, double min, double max)
        {
            if (min > max)
            {
                throw new InvalidOperationException();
            }

            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }

        /// <summary>
        /// Clamps a value
        /// </summary>
        public static int Clamp(int value, int min, int max)
        {
            if (min > max)
            {
                throw new InvalidOperationException();
            }

            if (value < min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            return value;
        }
    }
}
