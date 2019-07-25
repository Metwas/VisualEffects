namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Provides an easing interpolation by raising a current power value to 3
	/// </summary>
	public class CubicEaseFunction : PowerEaseFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public CubicEaseFunction(EaseMode mode)
			: base(3, mode)
		{
		}

		#endregion
	}
}
