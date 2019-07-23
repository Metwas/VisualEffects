namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Represents a timer based animation
	/// </summary>
	public abstract class AnimationBase : Timeline
	{
		#region Constructors

		/// <summary>
		/// Constructs an animation object with the specified framerate
		/// </summary>
		/// <param name="frameRate"></param>
		public AnimationBase(int frameRate, EasingFunction easingFunction, double duration)
			: base(frameRate, duration)
		{
			this.EasingFunction = easingFunction;
		}

		#endregion

		/// <summary>
		/// Represents the easing function for this animation
		/// </summary>
		public EasingFunction EasingFunction { get; }
	}
}
