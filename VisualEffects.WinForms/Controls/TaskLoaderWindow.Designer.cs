namespace VisualEffects.WinForms.Controls
{
	partial class TaskLoaderWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskLoaderWindow));
			this.LoaderImageContainer = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.LoaderImageContainer)).BeginInit();
			this.SuspendLayout();
			// 
			// LoaderImageContainer
			// 
			this.LoaderImageContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoaderImageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.LoaderImageContainer.Image = ((System.Drawing.Image)(resources.GetObject("LoaderImageContainer.Image")));
			this.LoaderImageContainer.Location = new System.Drawing.Point(292, 133);
			this.LoaderImageContainer.Margin = new System.Windows.Forms.Padding(0);
			this.LoaderImageContainer.Name = "LoaderImageContainer";
			this.LoaderImageContainer.Size = new System.Drawing.Size(122, 77);
			this.LoaderImageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.LoaderImageContainer.TabIndex = 0;
			this.LoaderImageContainer.TabStop = false;
			// 
			// TaskLoaderWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(699, 370);
			this.Controls.Add(this.LoaderImageContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskLoaderWindow";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "LoaderWindow";
			((System.ComponentModel.ISupportInitialize)(this.LoaderImageContainer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox LoaderImageContainer;
	}
}