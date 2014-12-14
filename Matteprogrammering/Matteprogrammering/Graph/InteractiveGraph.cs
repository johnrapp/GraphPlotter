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
		public DisplayMode DisplayMode;

		public EventHandler OnWindowChanged;


		public InteractiveGraph() {
			InitializeComponent();

			MouseCoords.Hide();
		}

		public override Window Window {
			get { return base.Window; }
			set {
				base.Window = value;

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
			if(e.Button == MouseButtons.Left) {
				if(LastPos != null) {
					PointF delta = LastPos.Subtract(e.Location);

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
			//Pos is already mouse pos
			switch(DisplayMode) {
				case DisplayMode.Function:
					output = new PointF(pos.X, (float) Function.Value(pos.X));
					break;
				case DisplayMode.Derivate:
					output = new PointF(pos.X, (float) Function.Derivate(pos.X));
					break;
			}

			MouseCoords.Text = output.Render(1);
		}

		private void OnMouseWheel(object sender, MouseEventArgs e) {
			PointF location = e.Location;

			PointF pos = Inverse.TransformPoint(location);

			Window = Window.Zoom(0.5f, pos, e.Delta < 0);

			Display(e.Location);
		}

	}
}
