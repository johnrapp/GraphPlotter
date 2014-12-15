using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Matteprogrammering.Extentions;

namespace Matteprogrammering {
	public partial class InteractiveGraph : Graph {
		//An interactive graph that responds to user input

		public DisplayMode DisplayMode;

		public EventHandler OnWindowChanged;


		public InteractiveGraph() {
			InitializeComponent();

			MouseCoords.Hide();
		}

		public override Window Window {
			get { return base.Window; }
			set {
				//Surround with try-catch since the value may be invalid and throw an exception
				try {
					base.Window = value;
				} catch {}

				//Call OnWindowChanged listeners
				if(OnWindowChanged != null) {
					OnWindowChanged(this, null);
				}
			}
		}

		private void OnMouseEnter(object sender, EventArgs e) {
			MouseCoords.Show();
		}

		private void OnMouseLeave(object sender, EventArgs e) {
			MouseCoords.Hide();
		}

		private PointF LastPos;
		private void OnMouseMove(object sender, MouseEventArgs e) {
			PointF location = Inverse.TransformPoint(e.Location);
			//If the left mousebutton is pressed
			if(e.Button == MouseButtons.Left) {
				if(LastPos != null) {
					//Calculate the difference between the current position and the last position
					PointF delta = LastPos.Subtract(e.Location);

					//Translate the window with the delta, transformed by the inverse
					Window += Inverse.TransformVector(delta);
				}
			} else {
				Display(location);
			}

			UserX = location.X;

			LastPos = e.Location;
		}

		private void Display(PointF pos) {
			PointF output = pos;
			//pos is already mouse pos so DisplayMode.Mouse does nothing
			switch(DisplayMode) {
				case DisplayMode.Function:
					output = new PointF(pos.X, (float) Function.Value(pos.X));
					break;
				case DisplayMode.Derivate:
					output = new PointF(pos.X, (float) Function.Derivate(pos.X));
					break;
			}

			//Render point with one decimal
			MouseCoords.Text = output.Render(1);
		}

		//2x Zoom
		private const float ZOOM_FACTOR = 0.5f;
		private void OnMouseWheel(object sender, MouseEventArgs e) {
			PointF location = e.Location;

			PointF pos = Inverse.TransformPoint(location);

			//Zoom out if the user scrolled down
			Window = Window.Zoom(ZOOM_FACTOR, pos, e.Delta < 0);
		}

	}
}
