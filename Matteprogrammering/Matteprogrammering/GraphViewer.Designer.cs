using Matteprogrammering.UI;
namespace Matteprogrammering
{
	partial class GraphViewer
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.FunctionPicker = new Matteprogrammering.UI.FunctionPicker();
			this.WindowController = new Matteprogrammering.UI.WindowController();
			this.Graph = new Matteprogrammering.InteractiveGraph();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 384);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Draw:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(15, 400);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(67, 17);
			this.checkBox1.TabIndex = 34;
			this.checkBox1.Tag = 1;
			this.checkBox1.Text = "Function";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Click += new System.EventHandler(this.OnToggleDrawMode);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(88, 400);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(66, 17);
			this.checkBox2.TabIndex = 35;
			this.checkBox2.Tag = 2;
			this.checkBox2.Text = "Tangent";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Click += new System.EventHandler(this.OnToggleDrawMode);
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(161, 400);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(54, 17);
			this.checkBox3.TabIndex = 36;
			this.checkBox3.Tag = 4;
			this.checkBox3.Text = "Trace";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.Click += new System.EventHandler(this.OnToggleDrawMode);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 420);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 37;
			this.label3.Text = "Display:";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(216, 437);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(65, 17);
			this.radioButton3.TabIndex = 40;
			this.radioButton3.Tag = Matteprogrammering.DisplayMode.Derivate;
			this.radioButton3.Text = "Derivate";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.Click += new System.EventHandler(this.OnSetDisplayMode);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(118, 437);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(96, 17);
			this.radioButton2.TabIndex = 39;
			this.radioButton2.Tag = Matteprogrammering.DisplayMode.Function;
			this.radioButton2.Text = "Function Value";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.Click += new System.EventHandler(this.OnSetDisplayMode);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(15, 437);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(97, 17);
			this.radioButton1.TabIndex = 38;
			this.radioButton1.TabStop = true;
			this.radioButton1.Tag = Matteprogrammering.DisplayMode.Mouse;
			this.radioButton1.Text = "Mouse Position";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.Click += new System.EventHandler(this.OnSetDisplayMode);
			// 
			// FunctionPicker
			// 
			this.FunctionPicker.Location = new System.Drawing.Point(12, 331);
			this.FunctionPicker.Name = "FunctionPicker";
			this.FunctionPicker.Size = new System.Drawing.Size(269, 52);
			this.FunctionPicker.TabIndex = 26;
			// 
			// WindowController
			// 
			this.WindowController.Location = new System.Drawing.Point(518, 12);
			this.WindowController.Name = "WindowController";
			this.WindowController.Size = new System.Drawing.Size(163, 184);
			this.WindowController.TabIndex = 25;
			this.WindowController.Window = null;
			// 
			// Graph
			// 
			this.Graph.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Graph.Location = new System.Drawing.Point(12, 12);
			this.Graph.Name = "Graph";
			this.Graph.Size = new System.Drawing.Size(500, 300);
			this.Graph.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 315);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 41;
			this.label2.Text = "Function:";
			// 
			// GraphViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 502);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FunctionPicker);
			this.Controls.Add(this.WindowController);
			this.Controls.Add(this.Graph);
			this.Name = "GraphViewer";
			this.Text = "GraphViewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private InteractiveGraph Graph;
		private WindowController WindowController;
		private FunctionPicker FunctionPicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Label label2;

	}
}