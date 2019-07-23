namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// An easing function controls a given value at a given time within an animation using interpolation
	/// </summary>
	public abstract class EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public EasingFunction(EaseMode mode)
		{
			this.Mode = mode;
		}

		#endregion

		/// <summary>
		/// Gets or sets the <see cref="EaseMode"/> interpolation modification type for this easing function
		/// </summary>
		public EaseMode Mode { get; set; }
	}
}
