namespace VisualEffects.Components.Animation
{
	public class LinearEaseFunction : EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public LinearEaseFunction(EaseMode mode)
			: base(mode)
		{
		}

		#endregion

		#region Functions

		/// <summary>
		/// Performs a linear interpolation algorithm based from the provided <see cref="double"/> elapsed time
		/// </summary>
		/// <param name="normalizedElapsedTime"></param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type <see cref="T"/></returns>
		protected override double EaseInCore(double normalizedElapsedTime, double duration)
		{
			// rate of change equals to the current elapsed time
			return normalizedElapsedTime;
		}


		#endregion
	}
}
