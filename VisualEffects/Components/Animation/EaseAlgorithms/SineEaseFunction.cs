using System;

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
			: this(1, mode)
		{
		}

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="angle">The angle in degrees</param>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public SineEaseFunction(int angle, EaseMode mode)
			: base(mode)
		{
			this.Angle = angle;
		}

		#endregion

		/// <summary>
		/// The angle of which the sine function will calculate in degrees
		/// </summary>
		public double Angle { get; set; }

		#region Functions

		/// <summary>
		/// Performs a sine interpolation algorithm following the formulae ' f(t) = 1 - [sin(1 - t) * PI/2] '
		/// </summary>
		/// <param name="normalizedElapsedTime"></param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type <see cref="T"/></returns>
		protected override double EaseInCore(double normalizedElapsedTime, double duration)
		{
			double change = (1 - normalizedElapsedTime);
			return 1 - (Math.Sin(change) * (Math.PI / 2)) * this.Angle;
		}

		#endregion
	}

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
			double change = 1 - Math.Pow(normalizedElapsedTime, 2);
			return 1 - Math.Sqrt(change);
		}

		#endregion
	}
}
