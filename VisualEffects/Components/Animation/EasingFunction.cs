using System;
using VisualEffects.Helpers.Extensions;

namespace VisualEffects.Components.Animation
{
	/// <summary>
	/// An easing function controls a given value at a given time within an animation using interpolation
	/// </summary>
	public abstract class EasingFunction
	{
		#region Constructors

		/// <summary>
		/// Constructs the easing function with a specified <see cref="EaseMode"/>
		/// </summary>
		/// <param name="mode">The interpolation modification type for this easing function</param>
		public EasingFunction(EaseMode mode)
		{
			this.Mode = mode;
		}

		#endregion

		/// <summary>
		/// Linear ease algorithm
		/// </summary>
		public static EasingFunction LinearEase = new LinearEaseFunction(EaseMode.EaseIn);

		/// <summary>
		/// Power ease algorithm
		/// </summary>
		/// <remarks>
		/// https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.animation.powerease?view=netframework-4.8
		/// </remarks>
		public static EasingFunction PowerEase = new PowerEaseFunction(EaseMode.EaseIn);

		/// <summary>
		/// Gets or sets the <see cref="EaseMode"/> interpolation modification type for this easing function
		/// </summary>
		public EaseMode Mode { get; set; }

		#region Functions

		/// <summary>
		/// All derived classes will implement custom easing algorithms here
		/// </summary>
		/// <param name="normalizedElapsedTime">The time value which is mapped from 0 to 1</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given as a <see cref="double"/></returns>
		protected abstract double EaseInCore(double normalizedElapsedTime, double duration);

		/// <summary>
		/// The main function which performs the easing algorithm depending on which <see cref="EaseMode"/> is selected.
		/// </summary>
		/// <param name="elapsedTime">The current elapsedTime which gets passed to the easing formulae</param>
		/// <param name="duration">The total time for an animation to complete in milliseconds</param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		public virtual double Apply(double elapsedTime, double duration)
		{
			double normalizedTime = this.NormalizeTime(elapsedTime, duration);
			//double negativeNormalizedTime = this.NegativeNormalizeTime(elapsedTime, duration);

			switch (this.Mode)
			{
				case EaseMode.EaseIn:
					return this.EaseInCore(normalizedTime, duration);
				case EaseMode.EaseOut:
					return this.EaseInCore(normalizedTime, duration);
				case EaseMode.EaseInOut:
					return this.PerformSwitchEase(normalizedTime, duration);
				default:
					return this.EaseInCore(normalizedTime, duration);
			}
		}

		/// <summary>
		/// The main function which performs the easing algorithm depending on which <see cref="EaseMode"/> is selected.
		/// </summary>
		/// <param name="elapsedTime">The current elapsedTime which gets passed to the easing formulae</param>
		/// <param name="duration">The total time for an animation to complete as a <see cref="TimeSpan"/></param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		public virtual double Apply(double elapsedTime, TimeSpan duration)
		{
			return this.Apply(elapsedTime, duration.TotalMilliseconds);
		}

		/// <summary>
		/// Performs both <see cref="EaseMode.EaseIn" /> and <see cref="EaseMode.EaseOut"/> at the specified switch timestamp
		/// </summary>
		/// <param name="elapsedTime">The current elapsedTime which gets passed to the easing formulae</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <param name="switchStart">The timestamp for the switch to take place</param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		protected virtual double PerformSwitchEase(double elapsedTime, double duration, TimeSpan? switchStart = null)
		{
			if (switchStart == null)
			{
				// default to the switch at the half-way point of the total animation duration
				switchStart = TimeSpan.FromMilliseconds(duration / 2);
			}

			if (elapsedTime >= switchStart.Value.TotalMilliseconds)
			{
				// perform ease-out
				return this.EaseInCore(-elapsedTime, duration);
			}
			else
			{
				// perform ease-in
				return this.EaseInCore(elapsedTime, duration);
			}
		}

		/// <summary>
		/// Normalizes the provided elapsed time to ensure that its between 0 and 1, using the map formulae
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected virtual double NormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, 0, 1);
		}

		/// <summary>
		/// Maps from 1 to 0 rather than the <see cref="NormalizeTime(double, double)"/> function which uses 0 to 1
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected virtual double NegativeNormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, 1, 0);
		}

		#endregion
	}
}
