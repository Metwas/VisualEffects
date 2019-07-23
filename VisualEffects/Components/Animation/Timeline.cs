using System;
using System.Diagnostics;
using System.Timers;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// Used to handle timeline timer completion phase
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="args"></param>
	public delegate void TimelineCompleteHandler(object sender, EventArgs args);

	/// <summary>
	/// Used to handle the timeline timer begin phase
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="args"></param>
	public delegate void TimelineBeginHandler(object sender, EventArgs args);

	/// <summary>
	/// USed to control and display an underlying <see cref="Timer"/>
	/// </summary>
	public class Timeline
	{
		#region Constructors

		/// <summary>
		/// Constructs an timeline object with the specified framerate and complete duration
		/// </summary>
		/// <param name="frameRate"></param>
		public Timeline(int frameRate, double duration)
		{
			this.DesiredFrameRate = frameRate;
			this._animationTimer = new Timer(this.DesiredFrameRate);
			this._stopwatch = new Stopwatch();
			this._animationTimer.Elapsed += this.AnimationTimer_Elapsed;
		}

		#endregion

		/// <summary>
		/// Used to handle timeline timer completion phase
		/// </summary>
		public event TimelineCompleteHandler  TimelineComplete = null;

		/// <summary>
		/// Used to handle timeline timer completion phase
		/// </summary>
		public event TimelineBeginHandler TimelineBegin = null;

		/// <summary>
		/// Base timer used to update a given object or value over an elapsed interval
		/// </summary>
		private Timer _animationTimer = null;

		/// <summary>
		/// Used to track elapsed time values
		/// </summary>
		private Stopwatch _stopwatch = null;

		/// <summary>
		/// The desired framerate for the animation
		/// </summary>
		private int _desiredFrameRate = 30;

		/// <summary>
		/// The desired framerate for the animation
		/// </summary>
		public int DesiredFrameRate
		{
			get
			{
				return this._desiredFrameRate;
			}
			set
			{
				if (value > 0 && value < 250)
				{
					this._desiredFrameRate = value;
				}
			}
		}

		/// <summary>
		/// The duration for this animation before completion
		/// </summary>
		public double Duration { get; }

		#region Functions

		/// <summary>
		/// Handles each elapsed timer event, updating the base animation value
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void AnimationTimer_Elapsed(object sender, ElapsedEventArgs e)
		{

		}


		#endregion

	}
}
