using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisualEffects.Helpers.Extensions
{
	/// <summary>
	/// Provides static mathematical helper functions
	/// </summary>
	public static class MathExtensions
	{
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
	}
}
