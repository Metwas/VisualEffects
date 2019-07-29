using System;
using System.Drawing;
using System.Windows.Forms;
using VisualEffects.Components.Animation;

namespace VisualEffects.WinForms.Controls
{
	public static class ControlPropertyAnimator
	{
		/// <summary>
		/// A default easing function used accross all animations
		/// </summary>
		public static EasingFunction DefaultEasingFunction = new QuadraticEaseFunction(EaseMode.EaseOut);

		/// <summary>
		/// Animates the <see cref="Form.Opacity"/> property with the given control parameters
		/// </summary>
		/// <param name="form">The <see cref="Form"/> to animate the opacity property</param>
		/// <param name="from">A starting position, if null, it will use the current opacity value</param>
		/// <param name="to">The final result, if null, it will be set to 1.0</param>
		/// <param name="duration">The duration for animation to complete</param>
		/// <param name="easingFunction">A defined <see cref="EasingFunction"/> to interpolate the animation values</param>
		public static void AnimateOpacity(this Form form, double duration, double? from, double? to, EasingFunction easingFunction = null)
		{
			if (form != null)
			{
				if (!from.HasValue)
				{
					from = form.Opacity;
				}

				if (!to.HasValue)
				{
					to = 1.0;
				}

				// ensure the UI thread updates the UI components
				Action<double> invoker = new Action<double>((value) =>
				{
					form.Opacity = value;
				});

				DoubleAnimation doubleAnimation = new DoubleAnimation(from.Value, to.Value, easingFunction ?? ControlPropertyAnimator.DefaultEasingFunction, duration);
				doubleAnimation.TimelineTick += (sender, args) =>
				{
					double currentValue = doubleAnimation.Current;
					form.BeginInvoke(invoker, currentValue);
				};

				doubleAnimation.Begin();
			}
		}

		/// <summary>
		/// Animates the <see cref="Control.BackColor"/> alpha channel
		/// </summary>
		/// <param name="form">A <see cref="Control"/></param>
		/// <param name="from">A starting position, if null, it will use the current opacity value</param>
		/// <param name="to">The final result, if null, it will be set to 1.0</param>
		/// <param name="duration">The duration for animation to complete</param>
		/// <param name="easingFunction">A defined <see cref="EasingFunction"/> to interpolate the animation values</param>
		public static void AnimateOpacity(this Control control, double duration, double? from, double? to, EasingFunction easingFunction = null)
		{
			if (control != null)
			{
				if (!from.HasValue)
				{
					from = 0.0;
				}

				if (!to.HasValue)
				{
					to = 1.0;
				}

				// ensure the UI thread updates the UI components
				Action<double> invoker = new Action<double>((value) =>
				{
					control.BackColor = Color.FromArgb((int)value * 255, control.BackColor.R, control.BackColor.G, control.BackColor.B);
				});

				DoubleAnimation doubleAnimation = new DoubleAnimation(from.Value, to.Value, easingFunction ?? ControlPropertyAnimator.DefaultEasingFunction, duration);
				doubleAnimation.TimelineTick += (sender, args) =>
				{
					double currentValue = doubleAnimation.Current;
					control.BeginInvoke(invoker, currentValue);
				};

				doubleAnimation.Begin();
			}
		}

		/// <summary>
		/// Animates a <see cref="Control"/> by adjusting the width and height whilst maintaining center position.
		/// </summary>
		/// <param name="control">A <see cref="Control"/></param>
		/// <param name="from">A starting position, if null, it will use the current opacity value</param>
		/// <param name="to">The final result, if null, it will be set to 1.0</param>
		/// <param name="duration">The duration for animation to complete</param>
		/// <param name="easingFunction">A defined <see cref="EasingFunction"/> to interpolate the animation values</param>
		public static void AnimateScale(this Control control, double duration, Size? from, Size? to, ScaleMode scaleMode, EasingFunction easingFunction = null)
		{
			if (control != null)
			{
				if (!from.HasValue)
				{
					from = new Size(control.Width, control.Height);
				}

				if (!to.HasValue)
				{
					to = new Size(control.Width, control.Height);
				}

				// ensure the UI thread updates the UI components
				Action<Size> invoker = new Action<Size>((value) =>
				{
					scaleMode.Apply(control, value);
				});

				double _fromFactor = 0.0;
				double _toFactor = 1.0;

				DoubleAnimation doubleAnimation = new DoubleAnimation(_fromFactor, _toFactor, easingFunction ?? ControlPropertyAnimator.DefaultEasingFunction, duration);
				doubleAnimation.TimelineTick += (sender, args) =>
				{
					double currentValue = doubleAnimation.Current;
					// create a size object based from the current factor

					Size _size = new Size((int)(to.Value.Width * currentValue), (int)(to.Value.Height * currentValue));
					control.BeginInvoke(invoker, _size);
				};

				control.Size = from.Value;
				doubleAnimation.Begin();
			}
		}
	}
}
