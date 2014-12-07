using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matteprogrammering {
	public partial class Assignment9 : Form {
		private TextBox[] WindowInputs;
		private Window Window {
			get { return Graph.Window; }
			set {
				try {
					Graph.Window = value;

					if(!hack2)
						RenderWindow();
				} catch(InvalidOperationException ex) { }
			}

		}
		private bool hack1 = false, hack2 = false;
		public Assignment9() {
			InitializeComponent();

			WindowInputs = new TextBox[] { MinX, MaxX, MinY, MaxY };

			Window = Window.DEFAULT;

			Graph.Function = new Polynomial(0, -5, 0, 1);

			Graph.OnWindowChanged += new EventHandler(OnWindowChanged);
		}

		private void RenderWindow() {
			hack1 = true;
			float[] bounds = Graph.Window.Bounds();
			for(int i = 0; i < WindowInputs.Length; i++) {
				WindowInputs[i].Text = Math.Round(bounds[i], 1).ToString();
			}
			hack1 = false;
		}


		private void WindowChanged(object sender, EventArgs e) {
			if(hack1) return;

			float[] bounds = new float[WindowInputs.Length];

			for(int i = 0; i < bounds.Length; i++) {
				if(!float.TryParse(WindowInputs[i].Text, out bounds[i]))
					return;
			}

			hack2 = true;
			Window = new Window(bounds);
			hack2 = false;
		}

		private void OnWindowChanged(object sender, EventArgs e) {
			if(hack2)
				return;

			RenderWindow();
		}

		private void Zoom(object sender, EventArgs e) {
			Button button = (Button) sender;

			Window = Window.Zoom(0.5f, (bool) button.Tag);
		}

		private void OnReset(object sender, EventArgs e) {
			Window = Window.DEFAULT;
		}
	}
}
