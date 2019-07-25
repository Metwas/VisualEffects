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
		public static EasingFunction LinearEase = new LinearEaseFunction();

		/// <summary>
		/// Power ease algorithm
		/// </summary>
		/// <remarks>
		/// https://docs.microsoft.com/en-us/dotnet/api/system.windows.media.animation.powerease?view=netframework-4.8
		/// </remarks>
		public static EasingFunction PowerEase = new PowerEaseFunction(EaseMode.EaseOut);

		/// <summary>
		/// Gets or sets the <see cref="EaseMode"/> interpolation modification type for this easing function
		/// </summary>
		public EaseMode Mode { get; set; }

		/// <summary>
		/// Used to keep track of the original animation time
		/// </summary>
		protected double ElapsedTime = 0;

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
		/// <param name="duration">The total time for an animation to complete as a <see cref="TimeSpan"/></param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		public virtual double Ease(double elapsedTime, TimeSpan duration)
		{
			return this.Ease(elapsedTime, duration.TotalMilliseconds);
		}

		/// <summary>
		/// The main function which performs the easing algorithm depending on which <see cref="EaseMode"/> is selected.
		/// </summary>
		/// <param name="elapsedTime">The current elapsedTime which gets passed to the easing formulae</param>
		/// <param name="duration">The total time for an animation to complete in milliseconds</param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		public double Ease(double elapsedTime, double duration)
		{
			this.ElapsedTime = elapsedTime;
			double normalizedTime = this.NormalizeTime(elapsedTime, duration);
			//double negativeNormalizedTime = this.NegativeNormalizeTime(elapsedTime, duration);

			switch (this.Mode)
			{
				case EaseMode.EaseIn:
					return this.EaseInCore(normalizedTime, duration);

				case EaseMode.EaseOut:
					// EaseOut is the same as EaseIn, except time is reversed & the result is flipped. 
					return 1.0 - this.EaseInCore(1.0 - normalizedTime, duration); ;

				case EaseMode.EaseInOut:
				default:
					// EaseInOut is a combination of EaseIn & EaseOut fit to the 0-1, 0-1 range.
					return (normalizedTime < 0.5) ?
							   this.EaseInCore(normalizedTime * 2.0, duration) * 0.5 :
						(1.0 - this.EaseInCore((1.0 - normalizedTime) * 2.0, duration)) * 0.5 + 0.5;
			}
		}

		/// <summary>
		/// Performs both <see cref="EaseMode.EaseIn" /> and <see cref="EaseMode.EaseOut"/> using the bezier curve formulae
		/// </summary>
		/// <param name="normalizedTime">The current elapsedTime which gets passed to the easing formulae</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The current animation progress for a given type as a <see cref="double"/></returns>
		protected virtual double PerformBezierEase(double normalizedTime, double duration)
		{
			return Math.Pow(normalizedTime, 2) * (1 / normalizedTime);
		}

		/// <summary>
		/// Normalizes the provided elapsed time to ensure that its between 0 and 1, using the map formulae
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected virtual double NormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, 0.0, 1.0);
		}

		/// <summary>
		/// Maps from 1 to 0 rather than the <see cref="NormalizeTime(double, double)"/> function which uses 0 to 1
		/// </summary>
		/// <param name="elapsedTime">The current total elapsed time</param>
		/// <param name="duration">The total time for an animation to complete</param>
		/// <returns>The normalized time as a <see cref="double"/></returns>
		protected virtual double NegativeNormalizeTime(double elapsedTime, double duration)
		{
			return elapsedTime.Map(0, duration, 1.0, 0.0);
		}

		/// <summary>
		/// Performs the ease out algorithm by adding (1 - t) * t to the EaseIn function result
		/// </summary>
		/// <param name="normalizedTime"></param>
		/// <returns>A <see cref="double"/> result</returns>
		protected double EaseOut(double normalizedTime, double duration)
		{
			return this.EaseInCore(normalizedTime, duration) * (2 - normalizedTime);
		}

		/// <summary>
		/// Performs the ease in function increasing the acceleration rate over time
		/// </summary>
		/// <param name="normalizedTime"></param>
		/// <returns>A <see cref="double"/> result</returns>
		protected double EaseIn(double normalizedTime, double duration)
		{
			return this.EaseInCore(normalizedTime, duration) * normalizedTime;
		}

		#endregion
	}
}
