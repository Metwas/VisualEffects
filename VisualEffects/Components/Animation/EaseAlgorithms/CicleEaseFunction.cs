using System;
using VisualEffects.Helpers.Extensions;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Provides sine ease function
	/// </summary>
	/// <remarks>
	/// https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.animation.sineease?view=netframework-4.8
	/// </remarks>
	public class CicleEaseFunction : EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public CicleEaseFunction(EaseMode mode)
			: base(mode)
		{
		}

		#endregion

		#region Functions

		/// <summary>
		/// Performs the following interpolation formulae ' f(t) = 1 - SQRT(1 - SQUARE(t)) '
		/// </summary>
		/// <param name="normalizedElapsedTime"></param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type <see cref="T"/></returns>
		protected override double EaseInCore(double normalizedElapsedTime, double duration)
		{
			//normalizedElapsedTime = Math.Max(0.0, Math.Min(1.0, normalizedElapsedTime));
			normalizedElapsedTime = normalizedElapsedTime.Clamp(0.0, 1.0);
			double change = 1 - normalizedElapsedTime * normalizedElapsedTime;
			return 1.0 - Math.Sqrt(change);
		}

		/// <summary>
		/// Overrides the base normal which changes the minimum and maximum values: From [0 , 1] To [-1 , 1]
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected override double NormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, -1.0, 1.0);
		}

		/// <summary>
		/// Overrides the base normal which changes the minimum and maximum values: From [0 , 1] To [1 , -1]
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected override double NegativeNormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, 1.0, -1.0);
		}

		#endregion
	}
}
