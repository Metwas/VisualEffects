using System;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Provides an easing interpolation by raising a current timestamp value to a provided Power value
	/// </summary>
	public class PowerEaseFunction : EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public PowerEaseFunction(EaseMode mode)
			: this(1, mode)
		{
		}

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public PowerEaseFunction(int power, EaseMode mode)
			: base(mode)
		{
			this.Power = power;
		}

		#endregion

		/// <summary>
		/// The power property changes how quickly the rate of change can occur
		/// </summary>
		public int Power { get; set; }

		#region Functions

		/// <summary>
		/// Performs a linear interpolation algorithm based from the provided <see cref="double"/> elapsed time
		/// </summary>
		/// <param name="normalizedElapsedTime"></param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type <see cref="T"/></returns>
		protected override double EaseInCore(double normalizedElapsedTime, double duration)
		{
			/*
				f(t) = t^P  where 'p' equals to the Power property
			 */

			return Math.Pow(normalizedElapsedTime, this.Power);
		}


		#endregion
	}
}
