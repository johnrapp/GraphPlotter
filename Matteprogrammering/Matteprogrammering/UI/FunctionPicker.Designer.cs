namespace Matteprogrammering.UI {
	partial class FunctionPicker {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.CubicTerm = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.QuadraticTerm = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.LinearTerm = new System.Windows.Forms.TextBox();
			this.ConstantTerm = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CubicTerm
			// 
			this.CubicTerm.Location = new System.Drawing.Point(149, 0);
			this.CubicTerm.Name = "CubicTerm";
			this.CubicTerm.Size = new System.Drawing.Size(20, 20);
			this.CubicTerm.TabIndex = 35;
			this.CubicTerm.Text = "0";
			this.CubicTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CubicTerm.TextChanged += new System.EventHandler(this.OnTextChange);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(169, 3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(15, 13);
			this.label10.TabIndex = 36;
			this.label10.Text = "x³";
			// 
			// QuadraticTerm
			// 
			this.QuadraticTerm.Location = new System.Drawing.Point(103, 0);
			this.QuadraticTerm.Name = "QuadraticTerm";
			this.QuadraticTerm.Size = new System.Drawing.Size(20, 20);
			this.QuadraticTerm.TabIndex = 32;
			this.QuadraticTerm.Text = "0";
			this.QuadraticTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.QuadraticTerm.TextChanged += new System.EventHandler(this.OnTextChange);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(123, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 13);
			this.label8.TabIndex = 33;
			this.label8.Text = "x²";
			// 
			// LinearTerm
			// 
			this.LinearTerm.Location = new System.Drawing.Point(60, 0);
			this.LinearTerm.Name = "LinearTerm";
			this.LinearTerm.Size = new System.Drawing.Size(20, 20);
			this.LinearTerm.TabIndex = 29;
			this.LinearTerm.Text = "10";
			this.LinearTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.LinearTerm.TextChanged += new System.EventHandler(this.OnTextChange);
			// 
			// ConstantTerm
			// 
			this.ConstantTerm.Location = new System.Drawing.Point(25, 0);
			this.ConstantTerm.Name = "ConstantTerm";
			this.ConstantTerm.Size = new System.Drawing.Size(20, 20);
			this.ConstantTerm.TabIndex = 27;
			this.ConstantTerm.Text = "10";
			this.ConstantTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ConstantTerm.TextChanged += new System.EventHandler(this.OnTextChange);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "y =";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(190, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 25;
			this.button4.Text = "Derive";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.OnDerive);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(46, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(13, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "+";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(80, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(12, 13);
			this.label7.TabIndex = 30;
			this.label7.Text = "x";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Location = new System.Drawing.Point(136, 3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(13, 13);
			this.label11.TabIndex = 34;
			this.label11.Text = "+";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(89, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(13, 13);
			this.label9.TabIndex = 31;
			this.label9.Text = "+";
			// 
			// FunctionPicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.CubicTerm);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.QuadraticTerm);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.LinearTerm);
			this.Controls.Add(this.ConstantTerm);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label9);
			this.Name = "FunctionPicker";
			this.Size = new System.Drawing.Size(268, 25);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CubicTerm;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox QuadraticTerm;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox LinearTerm;
		private System.Windows.Forms.TextBox ConstantTerm;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
	}
}
