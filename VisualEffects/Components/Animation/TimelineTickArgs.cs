using System;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Contains information after each <see cref="Timeline.Tick"/> event,
	/// such as the current time position which is used for the easing interpolation functions
	/// </summary>
	public class TimelineTickArgs : EventArgs
	{
		#region Constructors

		public TimelineTickArgs(double currentTime)
		{
			this.CurrentTime = currentTime;
		}

		#endregion

		/// <summary>
		/// The current timeline position
		/// </summary>
		public double CurrentTime { get; }
	}
}
