using System.Windows.Forms;

namespace VisualEffects.WinForms.Controls
{
	/// <summary>
	/// A event handler delagate for any <see cref="DialogResult"/> changes
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="args"></param>
	public delegate void DialogResultHandler(object sender, DialogResultArgs args);

	/// <summary>
	/// Represents an extended <see cref="Control"/> with a <see cref="System.Windows.Forms.DialogResult"/> property attached
	/// </summary>
	public class DialogControl : Control
	{
		#region Contructors

		public DialogControl(DialogResultHandler dialogEventHandler)
		{
			this.DialogChanged += dialogEventHandler;
			
		}

		#endregion

		/// <summary>
		/// The controls <see cref="DialogResult"/>
		/// </summary>
		private DialogResult _dialogResult = DialogResult.None;

		/// <summary>
		/// The event which listens for when this controls dialog state has changed
		/// </summary>
		public event DialogResultHandler DialogChanged;

		/// <summary>
		/// The controls <see cref="DialogResult"/>
		/// </summary>
		public DialogResult DialogResult
		{
			get
			{
				return this._dialogResult;
			}
			set
			{
				this._dialogResult = value;
				this.OnDialogChanged(new DialogResultArgs(value));
			}
		}

		#region Functions

		public new DialogResult Show()
		{
			return this.DialogResult;
		}

		/// <summary>
		/// Safely executes any registered event listeners for the <see cref="DialogChanged"/> event
		/// </summary>
		/// <param name="resultArgs"></param>
		protected void OnDialogChanged(DialogResultArgs resultArgs)
		{
			if(this.DialogChanged != null)
			{
				this.DialogChanged.Invoke(this, resultArgs);
			}
		}

		#endregion
	}
}
