namespace Matteprogrammering
{
	partial class InteractiveGraph
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MouseCoords = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// MouseCoords
			// 
			this.MouseCoords.AutoSize = true;
			this.MouseCoords.Location = new System.Drawing.Point(49, 40);
			this.MouseCoords.Name = "MouseCoords";
			this.MouseCoords.Size = new System.Drawing.Size(35, 13);
			this.MouseCoords.TabIndex = 1;
			this.MouseCoords.Text = "label1";
			// 
			// InteractiveGraph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.MouseCoords);
			this.Name = "InteractiveGraph";
			this.Size = new System.Drawing.Size(300, 200);
			this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
			this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
			this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.OnMouseWheel);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label MouseCoords;
	}
}
