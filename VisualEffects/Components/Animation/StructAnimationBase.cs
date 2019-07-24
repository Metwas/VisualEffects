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
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation in milliseconds</param>
		public StructAnimationBase(T from, T to, EasingFunction easingFunction, double duration)
			: this(from, to, easingFunction, duration, null)
		{
			this.From = from;
			this.To = to;
		}

		/// <summary>
		/// Constructs this struct with the from and to properties
		/// </summary>
		/// <param name="from">The starting position for a given value type</param>
		/// <param name="to">The end position for a given value type</param>
		/// <param name="frameRate">The internal timer elapsed delay</param>
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation</param>
		public StructAnimationBase(T from, T to, EasingFunction easingFunction, double duration, uint? frameRate)
			: base(easingFunction, duration, frameRate)
		{
			this.From = from;
			this.To = to;
			this.Precision = 4;
			// attach event listener to the Timeline.Tick 
			this.TimelineTick += this.Timeline_Tick;
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

		/// <summary>
		/// The current calculated positional based value of type <see cref="T"/>
		/// </summary>
		public T Current { get; protected set; }

		/// <summary>
		/// The precision value when rounding value types
		/// </summary>
		public int Precision { get; set; }

		#region Event Handlers

		/// <summary>
		/// Handles each <see cref="Timeline.TimelineTick"/> event, which measures the rate of change and sets <see cref="Current"/> property accordingly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		protected abstract void Timeline_Tick(object sender, TimelineTickArgs args);

		#endregion
	}
}
