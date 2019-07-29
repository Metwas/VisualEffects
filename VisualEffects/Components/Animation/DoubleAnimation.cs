using VisualEffects.Helpers.Extensions;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// This uses a <see cref="System.Timers.Timer"/> to control the rate of change on a set of generic value types [<see cref="T"/>] represented as 'From' and 'To'
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public sealed class DoubleAnimation : StructAnimationBase<double>
	{
		#region Constructors

		/// <summary>
		/// Constructs this struct with the from and to properties
		/// </summary>
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation in milliseconds</param>
		public DoubleAnimation(double from, double to, EasingFunction easingFunction, double duration)
			: this(from, to, easingFunction, duration, null)
		{
		}

		/// <summary>
		/// Constructs this struct with the from and to properties
		/// </summary>
		/// <param name="from">The starting position for a given value type</param>
		/// <param name="to">The end position for a given value type</param>
		/// <param name="frameRate">The internal timer elapsed delay</param>
		/// <param name="easingFunction">The easing algorithm</param>
		/// <param name="duration">The total duration to complete this animation</param>
		public DoubleAnimation(double from, double to, EasingFunction easingFunction, double duration, uint? frameRate)
			: base(from, to, easingFunction, duration, frameRate)
		{
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// Handles each <see cref="Timeline.TimelineTick"/> event, which measures the rate of change and sets <see cref="Current"/> property accordingly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		protected override void Timeline_Tick(object sender, TimelineTickArgs args)
		{
			this.Current = System.Math.Round(System.Math.Abs((this.To.Value - this.From.Value) * this.EasingFunction.Ease(args.CurrentTime, this.Duration)), this.Precision).Clamp(this.From.Value, this.To.Value);
		}

		#endregion
	}
}
