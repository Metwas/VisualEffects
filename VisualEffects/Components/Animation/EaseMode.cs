namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Represents the possible easing modes which changes the interpolation formulae
	/// </summary>
	public enum EaseMode
	{
		/// <summary>
		/// Interpolation follows the mathematical formula associated with the easing function.
		/// </summary>
		EaseIn = 1,

		/// <summary>
		/// Interpolation follows 100% interpolation minus the output of the formula associated with the easing function.
		/// </summary>
		EaseOut = 2,

		/// <summary>
		/// Interpolation uses EaseIn for the first half of the animation and EaseOut for the second half.
		/// </summary>
		EaseInOut = 3
	}
}
