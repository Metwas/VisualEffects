using System;
using System.Windows.Forms;

namespace VisualEffects.WinForms.Controls
{
	/// <summary>
	/// Event arguments containing a <see cref="DialogResult"/>
	/// </summary>
	public class DialogResultArgs : EventArgs
	{
		#region Constructors

		public DialogResultArgs(DialogResult result)
		{
			this.DialogResult = result;
		}

		#endregion

		/// <summary>
		/// The <see cref="DialogResult"/> returned after an event occurred
		/// </summary>
		public DialogResult DialogResult { get; }
	}
}
