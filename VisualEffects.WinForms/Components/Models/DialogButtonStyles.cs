using System.Drawing;

namespace VisualEffects.WinForms.Components.Models
{
	public static class DialogButtonStyles
	{
		/// <summary>
		/// The background <see cref="Color"/> for a positive <see cref="DialogResult"/> such as: YES, OK
		/// </summary>
		public static Color PositiveBackColor = Color.MediumSeaGreen;

		/// <summary>
		/// The background <see cref="Color"/> for a negative <see cref="DialogResult"/> such as: No
		/// </summary>
		public static Color NegativeBackColor = Color.FromArgb(255,192,0,0);

		/// <summary>
		/// The background <see cref="Color"/> for a neutral <see cref="DialogResult"/> such as: ABORT, CANCEL
		/// </summary>
		public static Color NeutralBackColor = Color.SteelBlue;
	}
}
