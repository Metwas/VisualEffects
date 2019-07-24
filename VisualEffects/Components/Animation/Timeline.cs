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
	public delegate void TimelineBeginHandler(object sender, TimelineBeginArgs args);

	/// <summary>
	/// Used to handle each elapsed timer update
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="args"></param>
	public delegate void TimelineTickHandler(object sender, TimelineTickArgs args);

	/// <summary>
	/// Used to control and display an underlying <see cref="Timer"/>
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
		public event TimelineCompleteHandler TimelineComplete = null;

		/// <summary>
		/// Used to handle timeline timer completion phase
		/// </summary>
		public event TimelineBeginHandler TimelineBegin = null;

		/// <summary>
		/// Used to handle every internal timer tick completion phase
		/// </summary>
		public event TimelineTickHandler TimelineTick = null;

		/// <summary>
		/// Base timer used to update a given object or value over an elapsed interval
		/// </summary>
		private Timer _animationTimer = null;

		/// <summary>
		/// Used to track elapsed time values
		/// </summary>
		private Stopwatch _stopwatch = null;

		/// <summary>
		/// Keeps a reference for the current timeline position
		/// </summary>
		private double _currentTimeElapsed = 0;

		/// <summary>
		/// The desired framerate for the animation
		/// </summary>
		private int _desiredFrameRate = 30;

		/// <summary>
		/// Keeps a record of the internal timer whether its currently enabled (if true, the elapsed event will continue to be raised)
		/// </summary>
		public bool IsRunning
		{
			get
			{
				return this._animationTimer.Enabled;
			}
		}

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
		/// Initializes the current elapsed time to the beginning
		/// </summary>
		public void Begin()
		{
			// start from the beginning
			this.BeginAt(0);
		}

		/// <summary>
		/// Initializes the current elapsed time to the provided startTime parameter
		/// </summary>
		/// <param name="time">The desired starting position</param>
		public void BeginAt(double startTime)
		{
			_currentTimeElapsed = startTime;
			this._animationTimer.Start();
			this._stopwatch = Stopwatch.StartNew();
			this.OnTimelineBegin(new TimelineBeginArgs(this.DesiredFrameRate, this.Duration, this._currentTimeElapsed));
		}

		/// <summary>
		/// Terminates the timer and completes the animation
		/// </summary>
		public void End()
		{
			if (this.IsRunning)
			{
				this._animationTimer.Stop();
				this.OnTimelineComplete(null);
			}
		}

		/// <summary>
		/// The recommended design principle for safely executing subscribed event handlers for the <see cref="Timeline.TimelineTick"/> event
		/// </summary>
		/// <param name="args"><see cref="TimelineTickArgs"/></param>
		protected virtual void OnTimelineTick(TimelineTickArgs args)
		{
			// ensure there are subscribed event handlers for this event
			if (this.TimelineTick != null)
			{
				this.TimelineTick(this, args);
			}
		}

		/// <summary>
		/// The recommended design principle for safely executing subscribed event handlers for the <see cref="Timeline.TimelineBegin"/> event
		/// </summary>
		/// <param name="args"><see cref="TimelineTickArgs"/></param>
		protected virtual void OnTimelineBegin(TimelineBeginArgs args)
		{
			// ensure there are subscribed event handlers for this event
			if (this.TimelineBegin != null)
			{
				this.TimelineBegin(this, args);
			}
		}

		/// <summary>
		/// The recommended design principle for safely executing subscribed event handlers for the <see cref="Timeline.TimelineComplete"/> event
		/// </summary>
		/// <param name="args"><see cref="TimelineTickArgs"/></param>
		protected virtual void OnTimelineComplete(EventArgs args)
		{
			// ensure there are subscribed event handlers for this event
			if (this.TimelineComplete != null)
			{
				this.TimelineComplete(this, args);
			}
		}

		#endregion

		#region Event Handlers


		/// <summary>
		/// Handles each elapsed timer event, updating the base animation value
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void AnimationTimer_Elapsed(object sender, ElapsedEventArgs e)
		{
			double totalElapsedTime = this._stopwatch.Elapsed.TotalMilliseconds + this._currentTimeElapsed;

			if(totalElapsedTime >= this.Duration)
			{
				// complete timeline
				this.End();
			}

			// add the current time elapsed with the stopwatch 
			this.OnTimelineTick(new TimelineTickArgs(totalElapsedTime));
		}

		#endregion

	}
}
