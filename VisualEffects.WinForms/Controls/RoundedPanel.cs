using System.Drawing;
using System.Windows.Forms;
using VisualEffects.Components.Graphics;

namespace VisualEffects.WinForms.Controls
{
	public partial class RoundedPanel : UserControl
	{
		#region Constructors

		public RoundedPanel()
		{
			InitializeComponent();
		}

		#endregion

		/// <summary>
		/// The border sizing for this panel
		/// </summary>
		public Padding Border { get; set; }

		/// <summary>
		/// The border radius for each corner on this panel
		/// </summary>
		public BorderRadius BorderRadius { get; set; }

		#region Functions

		/// <summary>
		/// Overrides the default user control paint and draws <see cref="Rectangle"/> for each corner to add a border-radius to the specified <see cref="BorderRadius"/> values
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{	
			base.OnPaint(e);
		}

		#endregion
	}
}
