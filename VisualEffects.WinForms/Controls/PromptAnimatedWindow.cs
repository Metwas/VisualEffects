using System;
using System.Drawing;
using System.Windows.Forms;
using VisualEffects.Components.Animation;
using VisualEffects.Helpers;
using VisualEffects.WinForms.Components.Models;

namespace VisualEffects.WinForms.Controls
{
	/// <summary>
	/// Animated prompt window
	/// </summary>
	public partial class PromptAnimatedWindow : Form
	{
		#region Contructors

		public PromptAnimatedWindow(Control parent)
		{
			InitializeComponent();

			// revert to the parent control from which created this prompt form
			if (parent == null)
			{
				throw new ArgumentNullException("No parent control was provided!");
			}

			this.ParentControl = parent;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Width = parent.Width;
			this.Height = parent.Height;
			this.Location = parent.Location;
		}

		#endregion

		/// <summary>
		/// The owner of this prompt window
		/// </summary>
		public Control ParentControl { get; }

		#region Functions

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public DialogResult Show(string message)
		{
			return this.Show(message, "Message", PromptMessageButtons.YesNo);
		}

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public DialogResult Show(string message, PromptMessageButtons buttons)
		{
			return this.Show(message, "", buttons);
		}

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public DialogResult Show(string message, string title)
		{
			return this.Show(message, title, PromptMessageButtons.YesNo);
		}

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public DialogResult Show(string message, string title, PromptMessageButtons buttons)
		{
			this.ParentControl.BringToFront();
			this.Title.Text = title;
			this.Message.Text = message;

			switch (buttons)
			{
				case PromptMessageButtons.Ok:
					this.Btn2.Text = DialogResult.OK.ToString();
					this.Btn2.Visible = true;
					this.Btn2.BackColor = DialogButtonStyles.PositiveBackColor;

					this.Btn1.Visible = false;
					this.Btn3.Visible = false;
					break;

				case PromptMessageButtons.OkCancel:
					this.Btn1.Text = DialogResult.OK.ToString();
					this.Btn1.Visible = true;
					this.Btn1.BackColor = DialogButtonStyles.PositiveBackColor;
					
					this.Btn3.Text = DialogResult.Cancel.ToString();
					this.Btn3.Visible = true;
					this.Btn3.BackColor = DialogButtonStyles.NeutralBackColor;

					this.Btn2.Visible = false;
					break;

				case PromptMessageButtons.YesNoCancel:
					this.Btn1.Text = DialogResult.Yes.ToString();
					this.Btn1.Visible = true;
					this.Btn1.BackColor = DialogButtonStyles.PositiveBackColor;

					this.Btn2.Text = DialogResult.Cancel.ToString();
					this.Btn2.Visible = true;
					this.Btn2.BackColor = DialogButtonStyles.NeutralBackColor;

					this.Btn3.Text = DialogResult.No.ToString();
					this.Btn3.Visible = true;
					this.Btn3.BackColor = DialogButtonStyles.NegativeBackColor;
					break;

				case PromptMessageButtons.YesNo:
					this.Btn1.Text = DialogResult.Yes.ToString();
					this.Btn1.Visible = true;
					this.Btn1.BackColor = DialogButtonStyles.PositiveBackColor;

					this.Btn3.Text = DialogResult.No.ToString();
					this.Btn3.Visible = true;
					this.Btn3.BackColor = DialogButtonStyles.NegativeBackColor;

					this.Btn2.Visible = false;
					break;

				default:
					break;
			}

			int _scale = 45;
			int _y = this.PromptPanel.Location.Y - _scale;
			this.PromptPanel.Location = new Point(this.PromptPanel.Location.X, _y);

			// ensure the UI thread updates the UI components
			Action<double> invoker = new Action<double>((value) =>
			{
				this.PromptPanel.Location = new Point(this.PromptPanel.Location.X, _y + (int)(_scale * value));
			});

			DoubleAnimation doubleAnimation = new DoubleAnimation(0.0, 1.0, new QuadraticEaseFunction(EaseMode.EaseOut), 300, 120);
			doubleAnimation.TimelineTick += (o, a) =>
			{
				double _current = doubleAnimation.Current;
				this.BeginInvoke(invoker, _current);
			};

			doubleAnimation.Begin();
			this.AnimateOpacity(300, 0.0, 0.6);

			return base.ShowDialog();
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// A generic button click handler from which attempts to a <see cref="DialogResult"/> from the text value of the button
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void BtnClick(object sender, EventArgs args)
		{
			if(sender is Button button)
			{
				try
				{
					// attempt to get the result based from the buttons text field
					DialogResult result = (DialogResult)EnumHelper.GetEnumFromValue(typeof(DialogResult), button.Text, StringComparison.OrdinalIgnoreCase);
					this.DialogResult = result;
				}
				catch(Exception e)
				{
					this.DialogResult = DialogResult.Cancel;
				}
				finally
				{
					this.Close();
				}
			}
		}

		#endregion
	}
}
