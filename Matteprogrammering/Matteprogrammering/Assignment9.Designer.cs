namespace Matteprogrammering
{
	partial class Assignment9
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
			this.MinX = new System.Windows.Forms.TextBox();
			this.MaxX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.MinY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.MaxY = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Graph = new Matteprogrammering.InteractiveGraph();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(320, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Min X";
			// 
			// MinX
			// 
			this.MinX.Location = new System.Drawing.Point(360, 13);
			this.MinX.Name = "MinX";
			this.MinX.Size = new System.Drawing.Size(100, 20);
			this.MinX.TabIndex = 2;
			this.MinX.TextChanged += new System.EventHandler(this.WindowChanged);
			// 
			// MaxX
			// 
			this.MaxX.Location = new System.Drawing.Point(360, 39);
			this.MaxX.Name = "MaxX";
			this.MaxX.Size = new System.Drawing.Size(100, 20);
			this.MaxX.TabIndex = 4;
			this.MaxX.TextChanged += new System.EventHandler(this.WindowChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(320, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max X";
			// 
			// MinY
			// 
			this.MinY.Location = new System.Drawing.Point(360, 65);
			this.MinY.Name = "MinY";
			this.MinY.Size = new System.Drawing.Size(100, 20);
			this.MinY.TabIndex = 6;
			this.MinY.TextChanged += new System.EventHandler(this.WindowChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(320, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Min Y";
			// 
			// MaxY
			// 
			this.MaxY.Location = new System.Drawing.Point(360, 91);
			this.MaxY.Name = "MaxY";
			this.MaxY.Size = new System.Drawing.Size(100, 20);
			this.MaxY.TabIndex = 8;
			this.MaxY.TextChanged += new System.EventHandler(this.WindowChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(320, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Max Y";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 129);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(65, 23);
			this.button1.TabIndex = 9;
			this.button1.Tag = false;
			this.button1.Text = "Zoom in";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Zoom);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(394, 129);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 23);
			this.button2.TabIndex = 10;
			this.button2.Tag = true;
			this.button2.Text = "Zoom out";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Zoom);
			// 
			// Graph
			// 
			this.Graph.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Graph.Location = new System.Drawing.Point(12, 12);
			this.Graph.Name = "Graph";
			this.Graph.Size = new System.Drawing.Size(300, 200);
			this.Graph.TabIndex = 11;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(319, 159);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 12;
			this.button3.Text = "Reset";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.OnReset);
			// 
			// Assignment9
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 442);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Graph);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.MaxY);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MinY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.MaxX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.MinX);
			this.Controls.Add(this.label1);
			this.Name = "Assignment9";
			this.Text = "Assignment9";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MinX;
		private System.Windows.Forms.TextBox MaxX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox MinY;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox MaxY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private InteractiveGraph Graph;
		private System.Windows.Forms.Button button3;

	}
}