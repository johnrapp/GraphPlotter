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
		public EventHandler OnWindowChanged;
		public Matrix CachedInverse;
		public InteractiveGraph() {
			InitializeComponent();

			MouseCoords.Hide();

			CachedInverse = Inverse;
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
			PointF location = e.Location;
			if(e.Button == MouseButtons.Left) {
				if(LastPos != null) {
					PointF delta = LastPos.Subtract(location);

					Window += Inverse.TransformVector(delta);
				}
			} else {
				DisplayMouseCoords(location);
			}

			LastPos = location;
		}

		private void DisplayMouseCoords(PointF mousePos) {
			mousePos = Inverse.TransformPoint(mousePos);
			MouseCoords.Text = "(" + Math.Round(mousePos.X, 1) + ", " + Math.Round(mousePos.Y, 1) + ")";
		}

		private void OnMouseWheel(object sender, MouseEventArgs e) {
			PointF location = e.Location;

			PointF pos = Inverse.TransformPoint(location);

			Window = Window.Zoom(0.5f, pos, e.Delta < 0);

			DisplayMouseCoords(e.Location);
		}

	}
}
