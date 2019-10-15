namespace VisualEffects.WinForms.Components.Models
{
	/// <summary>
	/// Used on creation for a prompt window control to define which set of buttons to display. Each button created will return a respected <see cref="System.Windows.Forms.DialogResult"/> once a mapped event is raised
	/// </summary>
	public enum PromptMessageButtons
	{ 
		/// <summary>
		/// Creates a plain yes button
		/// </summary>
		Yes = 0,

		/// <summary>
		/// Creates a set of yes and no buttons
		/// </summary>
		YesNo = 1,

		/// <summary>
		/// Creates a set of yes, no and cancel buttons
		/// </summary>
		YesNoCancel = 2,

		/// <summary>
		/// Creates a plain ok button
		/// </summary>
		Ok = 3,

		/// <summary>
		/// Creates a set of ok and cancel buttons
		/// </summary>
		OkCancel = 4
	}
}
