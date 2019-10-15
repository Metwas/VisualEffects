namespace VisualEffects.WinForms.Controls
{
	partial class PromptAnimatedWindow
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
			this.PromptPanel = new System.Windows.Forms.Panel();
			this.Message = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Btn2 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Btn3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Btn1 = new System.Windows.Forms.Button();
			this.Title = new System.Windows.Forms.Label();
			this.PromptPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// PromptPanel
			// 
			this.PromptPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PromptPanel.BackColor = System.Drawing.Color.White;
			this.PromptPanel.Controls.Add(this.Message);
			this.PromptPanel.Controls.Add(this.panel1);
			this.PromptPanel.Controls.Add(this.Title);
			this.PromptPanel.Location = new System.Drawing.Point(399, 256);
			this.PromptPanel.Name = "PromptPanel";
			this.PromptPanel.Padding = new System.Windows.Forms.Padding(5);
			this.PromptPanel.Size = new System.Drawing.Size(387, 211);
			this.PromptPanel.TabIndex = 0;
			// 
			// Message
			// 
			this.Message.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Message.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Message.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Message.Location = new System.Drawing.Point(5, 34);
			this.Message.Name = "Message";
			this.Message.Size = new System.Drawing.Size(377, 131);
			this.Message.TabIndex = 1;
			this.Message.Text = "Message";
			this.Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(5, 165);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(377, 41);
			this.panel1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.Btn2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(108, 0);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
			this.panel3.Size = new System.Drawing.Size(161, 41);
			this.panel3.TabIndex = 1;
			// 
			// Btn2
			// 
			this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Btn2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Btn2.FlatAppearance.BorderSize = 0;
			this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Btn2.Location = new System.Drawing.Point(8, 5);
			this.Btn2.Name = "Btn2";
			this.Btn2.Size = new System.Drawing.Size(145, 31);
			this.Btn2.TabIndex = 1;
			this.Btn2.Text = "Cancel";
			this.Btn2.UseVisualStyleBackColor = false;
			this.Btn2.Click += new System.EventHandler(this.BtnClick);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.Btn3);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(269, 0);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
			this.panel4.Size = new System.Drawing.Size(108, 41);
			this.panel4.TabIndex = 2;
			this.panel4.Click += new System.EventHandler(this.BtnClick);
			// 
			// Btn3
			// 
			this.Btn3.BackColor = System.Drawing.Color.SteelBlue;
			this.Btn3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Btn3.FlatAppearance.BorderSize = 0;
			this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Btn3.Location = new System.Drawing.Point(8, 5);
			this.Btn3.Name = "Btn3";
			this.Btn3.Size = new System.Drawing.Size(92, 31);
			this.Btn3.TabIndex = 1;
			this.Btn3.Text = "No";
			this.Btn3.UseVisualStyleBackColor = false;
			this.Btn3.Click += new System.EventHandler(this.BtnClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.Btn1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
			this.panel2.Size = new System.Drawing.Size(108, 41);
			this.panel2.TabIndex = 0;
			// 
			// Btn1
			// 
			this.Btn1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.Btn1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Btn1.FlatAppearance.BorderSize = 0;
			this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Btn1.Location = new System.Drawing.Point(8, 5);
			this.Btn1.Name = "Btn1";
			this.Btn1.Size = new System.Drawing.Size(92, 31);
			this.Btn1.TabIndex = 0;
			this.Btn1.Text = "Yes";
			this.Btn1.UseVisualStyleBackColor = false;
			this.Btn1.Click += new System.EventHandler(this.BtnClick);
			// 
			// Title
			// 
			this.Title.Dock = System.Windows.Forms.DockStyle.Top;
			this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Title.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Title.Location = new System.Drawing.Point(5, 5);
			this.Title.Name = "Title";
			this.Title.Padding = new System.Windows.Forms.Padding(5);
			this.Title.Size = new System.Drawing.Size(377, 29);
			this.Title.TabIndex = 0;
			this.Title.Text = "Title";
			// 
			// PromptAnimatedWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(1127, 680);
			this.Controls.Add(this.PromptPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PromptAnimatedWindow";
			this.Opacity = 0D;
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.PromptPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PromptPanel;
		private System.Windows.Forms.Label Message;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button Btn3;
		private System.Windows.Forms.Button Btn1;
		private System.Windows.Forms.Button Btn2;
	}
}