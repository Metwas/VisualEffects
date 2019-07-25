namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Provides an easing interpolation by raising a current power value to 2
	/// </summary>
	public class QuadraticEaseFunction : PowerEaseFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public QuadraticEaseFunction(EaseMode mode)
			: base(2, mode)
		{
		}

		#endregion
	}
}
