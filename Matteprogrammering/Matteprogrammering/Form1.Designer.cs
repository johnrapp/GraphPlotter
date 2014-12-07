namespace Matteprogrammering
{
	partial class Form1
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
			this.assignmentButton1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// assignmentButton1
			// 
			this.assignmentButton1.Location = new System.Drawing.Point(56, 97);
			this.assignmentButton1.Name = "assignmentButton1";
			this.assignmentButton1.Size = new System.Drawing.Size(75, 23);
			this.assignmentButton1.TabIndex = 0;
			this.assignmentButton1.Tag = 0;
			this.assignmentButton1.Text = "Uppgift 9";
			this.assignmentButton1.UseVisualStyleBackColor = true;
			this.assignmentButton1.Click += new System.EventHandler(this.OnChangeAssignment);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.assignmentButton1);
			this.Name = "Form1";
			this.Text = "Matteprogrammering";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button assignmentButton1;
	}
}

