using System;
using System.Drawing;
using System.Windows.Forms;
using VisualEffects.Components.Animation;
using VisualEffects.Helpers.Extensions;

namespace VisualEffects.Test
{
	public partial class AnimationTesterWindow : Form
	{
		#region Constructors

		public AnimationTesterWindow()
		{
			InitializeComponent();
			this.doubleAnimation = new DoubleAnimation(0.0, 155.0, new LinearEaseFunction(EaseMode.EaseIn), 500, 120);

			this.doubleAnimation.TimelineComplete += (o, a) =>
			{
				Action _invoker = new Action(() =>
				{
					this.StateLabel.Text = "Not Running";
					this.StateLabel.ForeColor = Color.Firebrick;
				});

				this.BeginInvoke(_invoker);
			};

			this.doubleAnimation.TimelineTick += (o, a) =>
			{
				Action _invoker = new Action(() =>
				{
					if (this.doubleAnimation.IsRunning)
					{
						this.StateLabel.Text = "Running";
						this.StateLabel.ForeColor = Color.MediumSpringGreen;
					}
					else
					{
						this.StateLabel.Text = "Not Running";
						this.StateLabel.ForeColor = Color.Firebrick;
					}

					double _currentValue = this.doubleAnimation.Current;

					this.AnimationStatusLabel.Text = "Moving box to the right";
					this.DoubleAnimateObject.Location = new Point((int)_currentValue, this.DoubleAnimateObject.Location.Y);
					this.Opacity = _currentValue.Map(this.doubleAnimation.From.Value, this.doubleAnimation.To.Value, 0, 1);
					this.Location = new Point(this.Location.X, (int)_currentValue);
					this.DoubleValueLabel.Text = _currentValue.ToString();
				});

				this.BeginInvoke(_invoker);
			};
		}

		#endregion

		public DoubleAnimation doubleAnimation = null;

		#region Event Handlers

		/// <summary>
		/// Starts a double animation sequence
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DoubleAnimationBtn_Click(object sender, EventArgs e)
		{
			this.doubleAnimation.Begin();
		}

		#endregion
	}
}
