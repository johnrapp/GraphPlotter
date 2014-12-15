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
			this.label5 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.FunctionSelect = new System.Windows.Forms.ComboBox();
			this.FunctionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 26;
			this.label5.Text = "y =";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(130, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 25;
			this.button4.Text = "Derive";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.OnDerive);
			// 
			// FunctionSelect
			// 
			this.FunctionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FunctionSelect.FormattingEnabled = true;
			this.FunctionSelect.Location = new System.Drawing.Point(3, 3);
			this.FunctionSelect.Name = "FunctionSelect";
			this.FunctionSelect.Size = new System.Drawing.Size(121, 21);
			this.FunctionSelect.TabIndex = 37;
			this.FunctionSelect.SelectedIndexChanged += new System.EventHandler(this.OnSelectFunction);
			// 
			// FunctionLabel
			// 
			this.FunctionLabel.AutoSize = true;
			this.FunctionLabel.Location = new System.Drawing.Point(21, 29);
			this.FunctionLabel.Name = "FunctionLabel";
			this.FunctionLabel.Size = new System.Drawing.Size(70, 13);
			this.FunctionLabel.TabIndex = 38;
			this.FunctionLabel.Text = "function label";
			// 
			// FunctionPicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.FunctionLabel);
			this.Controls.Add(this.FunctionSelect);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Name = "FunctionPicker";
			this.Size = new System.Drawing.Size(210, 47);
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox FunctionSelect;
		private System.Windows.Forms.Label FunctionLabel;
	}
}
