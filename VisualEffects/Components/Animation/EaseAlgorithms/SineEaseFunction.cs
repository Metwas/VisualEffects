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
	public class SineEaseFunction : EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public SineEaseFunction(EaseMode mode)
			: base(mode)
		{ 
		}

		#endregion

		#region Functions

		/// <summary>
		/// Performs a sine interpolation algorithm following the formulae ' f(t) = 1 - [sin(1 - t) * PI/2] '
		/// </summary>
		/// <param name="normalizedElapsedTime"></param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type <see cref="T"/></returns>
		protected override double EaseInCore(double normalizedElapsedTime, double duration)
		{
			return 1.0 - Math.Sin(Math.PI * 0.5 * (1 - normalizedElapsedTime));
		}

		#endregion
	}
}
