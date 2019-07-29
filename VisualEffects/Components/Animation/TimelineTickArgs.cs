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

		public TimelineTickArgs(double currentTime,double lastElapsed)
		{
			this.CurrentTime = currentTime;
			this.LastElapsed = lastElapsed;
		}

		#endregion

		/// <summary>
		/// The current timeline position
		/// </summary>
		public double CurrentTime { get; }

		/// <summary>
		/// Gets the timestamp from the last elapsed measurement 
		/// </summary>
		public double LastElapsed { get; }
	}
}
