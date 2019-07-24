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
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation in milliseconds</param>
		/// <param name="frameRate">The internal timer elapsed delay</param>
		public AnimationBase(EasingFunction easingFunction, double duration, uint? frameRate)
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
