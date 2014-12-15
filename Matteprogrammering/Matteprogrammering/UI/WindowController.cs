using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matteprogrammering.UI {
	public partial class WindowController : UserControl {
		private TextBox[] Inputs;
		public EventHandler OnWindowChanged;
		private Window window;
		public WindowController() {
			InitializeComponent();
			Inputs = new TextBox[] { MinX, MaxX, MinY, MaxY };
		}
		public Window Window {
			get { return window; }
			set {
				//Prevent windows forms bug
				if(value == null) return;
				
				window = value;
				if(OnWindowChanged != null) {
					OnWindowChanged(this, null);
				}
				Render();
			}
		}

		private void Render() {
			float[] bounds = Window.Bounds();
			for(int i = 0; i < Inputs.Length; i++) {
				Inputs[i].Text = Math.Round(bounds[i], 1).ToString();
			}
		}

		private void OnTextChanged(object sender, EventArgs e) {
			float[] bounds = new float[Inputs.Length];

			for(int i = 0; i < bounds.Length; i++) {
				if(!float.TryParse(Inputs[i].Text, out bounds[i]))
					return;
			}

			Window = new Window(bounds);
		}

		private void OnZoom(object sender, EventArgs e) {
			Button button = (Button)sender;

			Window = Window.Zoom(0.5f, (bool)button.Tag);
		}

		private void OnReset(object sender, EventArgs e) {
			Window = Window.DEFAULT;
		}

		private void OnCenter(object sender, EventArgs e) {
			Window = Window.Center();
		}
	}
}
