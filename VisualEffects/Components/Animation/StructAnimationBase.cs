namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// This uses a <see cref="System.Timers.Timer"/> to control the rate of change on a set of generic value types [<see cref="T"/>] represented as 'From' and 'To'
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class StructAnimationBase<T> : AnimationBase where T : struct
	{
		#region Constructors

		/// <summary>
		/// Constructs this struct with the from and to properties
		/// </summary>
		/// <param name="frameRate">The internal timer elapsed delay</param>
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation</param>
		public StructAnimationBase(T from, T to, EasingFunction easingFunction, uint frameRate, double duration)
			: base(frameRate, easingFunction, duration)
		{
		}

		#endregion

		/// <summary>
		/// The starting position for a given value type
		/// </summary>
		public T? From { get; set; }

		/// <summary>
		/// The end position for a given value type
		/// </summary>
		public T? To { get; set; }

		#region Functions



		#endregion
	}
}
