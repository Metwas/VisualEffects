using System;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Used to hold information about the current initialized <see cref="Timeline"/>
	/// </summary>
	public class TimelineBeginArgs : EventArgs
	{
		#region Constructors

		/// <summary>
		/// Constructs this event args with the specified framerate and duration for this timeline
		/// </summary>
		/// <param name="frameRate"></param>
		/// <param name="duration"></param>
		public TimelineBeginArgs(int frameRate, double duration)
		{
			this.Duration = duration;
			this.FrameRate = frameRate;
		}

		#endregion

		/// <summary>
		/// The framerate for a given <see cref="Timeline"/>
		/// </summary>
		public int FrameRate { get; }

		/// <summary>
		/// The duration for a given <see cref="Timeline"/>
		/// </summary>
		public double Duration { get; }
	}
}
