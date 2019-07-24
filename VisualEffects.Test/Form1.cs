using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualEffects.Components.Animation;
using VisualEffects.Helpers.Extensions;

namespace VisualEffects.Test
{
	public partial class AnimationTesterWindow : Form
	{
		public AnimationTesterWindow()
		{
			InitializeComponent();
			this.doubleAnimation = new DoubleAnimation(0.0, 155.0, EasingFunction.LinearEase, 5000, 30);

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
					this.Opacity = _currentValue.Map(0, 155, 0, 1);
					this.DoubleValueLabel.Text = _currentValue.ToString();
				});

				this.BeginInvoke(_invoker);
			};
		}

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
