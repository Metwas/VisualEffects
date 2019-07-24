using System;

namespace VisualEffects.Helpers.Extensions
{
	/// <summary>
	/// Provides static mathematical helper functions
	/// </summary>
	public static class MathExtensions
	{
		/// <summary>
		/// Converts provided degree value to radians
		/// </summary>
		/// <param name="degrees"></param>
		/// <returns><see cref="double"/></returns>
		public static double DEG_TO_RAD(double degrees)
		{
			return (Math.PI / 180) * degrees;
		}

		/// <summary>
		/// Converts provided radian value to degrees
		/// </summary>
		/// <param name="degrees"></param>
		/// <returns><see cref="double"/></returns>
		public static double RAD_TO_DEG(double radians)
		{
			return (180 / Math.PI) * radians;
		}

		#region Map

		/// <summary>
		/// Maps a range of values to a set of compressed or expanded equivalant values
		/// </summary>
		public static decimal Map(this decimal value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget)
		{
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}

		/// <summary>
		/// Maps a range of values to a set of compressed or expanded equivalant values
		/// </summary>
		public static double Map(this double value, double fromSource, double toSource, double fromTarget, double toTarget)
		{
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}

		/// <summary>
		/// Maps a range of values to a set of compressed or expanded equivalant values
		/// </summary>
		public static int Map(this int value, int fromSource, int toSource, int fromTarget, int toTarget)
		{
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}

		#endregion

		#region Clamps & filters

		/// <summary>
		/// Ensures the extended value falls within a specific limit
		/// </summary>
		/// <param name="value">The extended value</param>
		/// <param name="maximum">The minimum value</param>
		/// <param name="maximum">The maximum value</param>
		/// <returns>A <see cref="decimal"/> value which will be less or equal to the <see cref="maximum"/> parameter</returns>
		public static decimal Clamp(this decimal value, decimal minimum, decimal maximum)
		{
			return Math.Max(minimum, Math.Min(value, maximum));
		}

		/// <summary>
		/// Ensures the extended value falls within a specific limit
		/// </summary>
		/// <param name="value">The extended value</param>
		/// <param name="maximum">The minimum value</param>
		/// <param name="maximum">The maximum value</param>
		/// <returns>A <see cref="double"/> value which will be less or equal to the <see cref="maximum"/> parameter</returns>
		public static double Clamp(this double value, double minimum, double maximum)
		{
			return Math.Max(minimum, Math.Min(value, maximum));
		}

		/// <summary>
		/// Ensures the extended value falls within a specific limit
		/// </summary>
		/// <param name="value">The extended value</param>
		/// <param name="maximum">The minimum value</param>
		/// <param name="maximum">The maximum value</param>
		/// <returns>A <see cref="int"/> value which will be less or equal to the <see cref="maximum"/> parameter</returns>
		public static int Clamp(this int value, int minimum, int maximum)
		{
			return Math.Max(minimum, Math.Min(value, maximum));
		}

		#endregion
	}
}
