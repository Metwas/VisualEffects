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
		/// <param name="frameRate"The desired framerate></param>
		/// <param name="duration">The duration until completion</param>
		/// <param name="elapsedTime">The current total elapsed time</param>
		public TimelineBeginArgs(uint frameRate, double duration, TimeSpan elapsedTime)
		{
			this.Duration = duration;
			this.FrameRate = frameRate;
			this.Elapsed = elapsedTime;
		}

		/// <summary>
		/// Constructs this event args with the specified framerate and duration for this timeline
		/// </summary>
		/// <param name="frameRate"The desired framerate></param>
		/// <param name="duration">The duration until completion</param>
		/// <param name="elapsedTime">The current total elapsed time in milliseconds</param>
		public TimelineBeginArgs(uint frameRate, double duration, double elapsedMilliseconds)
			: this(frameRate, duration, TimeSpan.FromMilliseconds(elapsedMilliseconds))
		{
		}

		#endregion

		/// <summary>
		/// The framerate for a given <see cref="Timeline"/>
		/// </summary>
		public uint FrameRate { get; }

		/// <summary>
		/// The duration for a given <see cref="Timeline"/>
		/// </summary>
		public double Duration { get; }

		/// <summary>
		/// The total running time as a <see cref="TimeSpan"/>
		/// </summary>
		public TimeSpan Elapsed { get; }
	}
}
