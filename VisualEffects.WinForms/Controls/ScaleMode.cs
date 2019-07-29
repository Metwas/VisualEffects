using System;
using System.Drawing;
using System.Windows.Forms;

namespace VisualEffects.WinForms.Controls
{
	public sealed class ScaleMode
	{
		#region Constructors

		public ScaleMode(Action<Control, Size> scaleFunction)
		{
			this.ScaleFunction = scaleFunction;
		}

		#endregion

		/// <summary>
		/// A default scale mode, which only sets the control size to the provided size parameter
		/// </summary>
		public static readonly ScaleMode Default = new ScaleMode((control, size) =>
		{
			control.Size = size;
		});

		/// <summary>
		/// Sets a <see cref="Control.Size"/> property whilst maintaining a centered location against the <see cref="Control.Parent"/>
		/// </summary>
		public static readonly ScaleMode Center = new ScaleMode((control, size) =>
		{
			Size parent = Size.Empty;

			if (control.Parent == null)
			{
				// assign the parent size parameters to the working screen area
				parent.Width = Screen.PrimaryScreen.WorkingArea.Width;
				parent.Height = Screen.PrimaryScreen.WorkingArea.Height;
			}

			control.Size = size;

			//int _xRatio = control.Size.Width / size.Width;
			//int _yRatio = control.Size.Height / size.Height;

			int _x = control.Location.X / 2 + (parent.Width / 2 - control.Width / 2);
			int _y = control.Location.Y / 2 + (parent.Height / 2 - control.Height / 2);

			control.Location = new Point(_x, _y);
		});

		/// <summary>
		/// A custom <see cref="Action{T1, T2}"/> delagate which handles a <see cref="Control"/>
		/// </summary>
		public Action<Control, Size> ScaleFunction { get; }

		#region Functions

		/// <summary>
		/// Calls the <see cref="ScaleFunction"/> with the provided parameters
		/// </summary>
		/// <param name="control">A <see cref="Control"/></param>
		/// <param name="current">The new size to scale this control to</param>
		public void Apply(Control control, Size current)
		{
			this.ScaleFunction.Invoke(control, current);
		}

		#endregion
	}
}
