namespace VisualEffects.Test
{
	partial class AnimationTesterWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.DoubleValueLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DoubleAnimationBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.StateLabel = new System.Windows.Forms.Label();
			this.DoubleAnimateObject = new System.Windows.Forms.Button();
			this.AnimationStatusLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "DoubleAnimation";
			// 
			// DoubleValueLabel
			// 
			this.DoubleValueLabel.AutoSize = true;
			this.DoubleValueLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoubleValueLabel.ForeColor = System.Drawing.Color.White;
			this.DoubleValueLabel.Location = new System.Drawing.Point(62, 57);
			this.DoubleValueLabel.Name = "DoubleValueLabel";
			this.DoubleValueLabel.Size = new System.Drawing.Size(13, 13);
			this.DoubleValueLabel.TabIndex = 1;
			this.DoubleValueLabel.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(13, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Value:";
			// 
			// DoubleAnimationBtn
			// 
			this.DoubleAnimationBtn.Location = new System.Drawing.Point(16, 238);
			this.DoubleAnimationBtn.Name = "DoubleAnimationBtn";
			this.DoubleAnimationBtn.Size = new System.Drawing.Size(179, 49);
			this.DoubleAnimationBtn.TabIndex = 3;
			this.DoubleAnimationBtn.Text = "Start";
			this.DoubleAnimationBtn.UseVisualStyleBackColor = true;
			this.DoubleAnimationBtn.Click += new System.EventHandler(this.DoubleAnimationBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(13, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "State:";
			// 
			// StateLabel
			// 
			this.StateLabel.AutoSize = true;
			this.StateLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StateLabel.ForeColor = System.Drawing.Color.Firebrick;
			this.StateLabel.Location = new System.Drawing.Point(62, 82);
			this.StateLabel.Name = "StateLabel";
			this.StateLabel.Size = new System.Drawing.Size(73, 13);
			this.StateLabel.TabIndex = 5;
			this.StateLabel.Text = "Not Running";
			// 
			// DoubleAnimateObject
			// 
			this.DoubleAnimateObject.BackColor = System.Drawing.Color.DimGray;
			this.DoubleAnimateObject.Location = new System.Drawing.Point(14, 150);
			this.DoubleAnimateObject.Name = "DoubleAnimateObject";
			this.DoubleAnimateObject.Size = new System.Drawing.Size(53, 48);
			this.DoubleAnimateObject.TabIndex = 6;
			this.DoubleAnimateObject.Text = "┴";
			this.DoubleAnimateObject.UseVisualStyleBackColor = false;
			// 
			// AnimationStatusLabel
			// 
			this.AnimationStatusLabel.AutoSize = true;
			this.AnimationStatusLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnimationStatusLabel.ForeColor = System.Drawing.Color.White;
			this.AnimationStatusLabel.Location = new System.Drawing.Point(12, 125);
			this.AnimationStatusLabel.Name = "AnimationStatusLabel";
			this.AnimationStatusLabel.Size = new System.Drawing.Size(55, 13);
			this.AnimationStatusLabel.TabIndex = 7;
			this.AnimationStatusLabel.Text = "Move box";
			// 
			// AnimationTesterWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.AnimationStatusLabel);
			this.Controls.Add(this.DoubleAnimateObject);
			this.Controls.Add(this.StateLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DoubleAnimationBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.DoubleValueLabel);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AnimationTesterWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Animation Tester";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label DoubleValueLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button DoubleAnimationBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label StateLabel;
		private System.Windows.Forms.Button DoubleAnimateObject;
		private System.Windows.Forms.Label AnimationStatusLabel;
	}
}

