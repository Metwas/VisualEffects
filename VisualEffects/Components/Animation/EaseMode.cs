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
		IN = 0,

		/// <summary>
		/// Interpolation uses EaseIn for the first half of the animation and EaseOut for the second half.
		/// </summary>
		OUT = 1,

		/// <summary>
		/// Interpolation follows 100% interpolation minus the output of the formula associated with the easing function.
		/// </summary>
		INOUT = 2
	}
}
