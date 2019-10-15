using System;
using System.Windows.Forms;

namespace VisualEffects.WinForms.Components.Models
{
	/// <summary>
	/// Represents a model required for a prompt controller
	/// </summary>
	public class PromptModel
	{
		#region Constructors

		public PromptModel(string message, string title, PromptMessageButtons buttons)
		{
			if (string.IsNullOrEmpty(title))
			{
				title = "Prompt";
			}

			if (string.IsNullOrEmpty(message))
			{
				throw new ArgumentNullException("Message parameter must be provided!");
			}

			this.Title = title;
			this.Message = message;
			this.ButtonType = buttons;
		}

		#endregion

		/// <summary>
		/// The title for the prompt control
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// The message for the prompt control
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// The button types for the prompt control to display
		/// </summary>
		public PromptMessageButtons ButtonType { get; set; }
	}
}
