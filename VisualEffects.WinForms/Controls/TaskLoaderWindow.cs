using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualEffects.WinForms.Controls
{
	/// <summary>
	/// Displays a full size loader window for the duration of a delagate execution
	/// </summary>
	public partial class TaskLoaderWindow : Form
	{
		#region Constructors

		public TaskLoaderWindow(Control parent)
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

			this.CenterLoaderImage();
		}

		public TaskLoaderWindow(Control parent, Action @delagate)
			: this(parent)
		{
			this.HandleCompletion(@delagate);
		}

		#endregion

		/// <summary>
		/// This event will be raised once a provided task to the loader window has completed
		/// </summary>
		public event EventHandler TaskCompleted = null;

		/// <summary>
		/// The owner of this prompt window
		/// </summary>
		public Control ParentControl { get; }

		#region Functions

		/// <summary>
		/// This is a base completion handler which raises the <see cref="TaskCompleted"/> event
		/// </summary>
		private void BaseHandleCompletionCallback()
		{
			this.OnTaskCompletion(null);
			// animate out
			this.AnimateOpacity(350, 1.0, 0.0);
			this.DialogResult = DialogResult.OK;
		}

		/// <summary>
		/// Handles the asynchronous call and notifies any <see cref="TaskCompleted"/> event listeners after completion
		/// </summary>
		/// <param name="delagate"><see cref="Action"/></param>
		private async void HandleCompletion(Action @delagate)
		{
			await this.ExecuteDelagateAsync(@delagate);
			this.BaseHandleCompletionCallback();
		}

		/// <summary>
		/// Executes a provided <see cref="Action"/> delagate asynchronously
		/// </summary>
		/// <param name="delagate"><see cref="Action"/></param>
		/// <returns></returns>
		private Task ExecuteDelagateAsync(Action @delagate)
		{
			return Task.Factory.StartNew(@delagate);
		}

		/// <summary>
		/// Centers the <see cref="LoaderImageContainer"/> within the parent window
		/// </summary>
		private void CenterLoaderImage()
		{
			int loaderWidth = this.LoaderImageContainer.Width;
			int loaderHeight = this.LoaderImageContainer.Height;

			this.LoaderImageContainer.Location = new System.Drawing.Point(this.Width / 2 - loaderWidth / 2, this.Height / 2 - loaderHeight / 2);
		}

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public DialogResult Show(Action task)
		{
			this.HandleCompletion(task);
			this.AnimateOpacity(300, 0.0, 0.6);
			return base.ShowDialog();
		}

		/// <summary>
		/// Animates this prompt in with the specified options
		/// </summary>
		public new void Hide()
		{
			this.AnimateOpacity(300, 0.6, 0.0);
			base.Hide();
		}

		/// <summary>
		/// Safely notifies all event listeners for the <see cref="TaskCompleted"/> event
		/// </summary>
		/// <param name="args"></param>
		protected virtual void OnTaskCompletion(EventArgs args)
		{
			if (this.TaskCompleted != null)
			{
				this.TaskCompleted.Invoke(this, args);
			}
		}

		#endregion
	}
}
