using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matteprogrammering
{
	public partial class Form1 : Form
	{
		Form[] Assignments;
		public Form1()
		{
			InitializeComponent();
			Assignments = new Form[] {
				new GraphViewer()
			};
		}

		private void OnChangeAssignment(object sender, EventArgs e)
		{
			//Börja på uppgift 9, valfria konstanter
			Button pressedButton = (Button) sender;
			Form form = Assignments[(int) pressedButton.Tag];
			form.Show();
		}
	}
}
