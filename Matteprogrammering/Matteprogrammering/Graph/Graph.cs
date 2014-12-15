using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matteprogrammering {
	public partial class Graph : BaseGraph {
		//Graph class that renders the graph
		//A bitmask is used to set flags regarding what to render

		//Just render the function by default
		private int DrawMask = DrawMode.Function;
		private int RedrawMask = DrawMode.Tangent | DrawMode.Trace;
		protected double userX = 0;

		public Graph() {
			InitializeComponent();
		}

		//What x-value the user is interested in
		protected double UserX {
			get { return userX; }
			set {
				userX = value;
				//Only re-render in certain modes
				if((DrawMask & RedrawMask) > 0) {
					Render();
				}
			}
		}

		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);

			Graphics g = e.Graphics;
			if(IsEnabled(DrawMode.Function)) {
				Plot(Function, g, Pens.Black);
			}
			if(IsEnabled(DrawMode.Tangent)) {
				Plot(Function.Tangent(UserX), g, Pens.Red);
			}
			if(IsEnabled(DrawMode.Trace)) {
				Trace(UserX, g, Pens.Red);
			}
		}

		//Functions that can get and set different modes from the bitmask
		public void Toggle(int mode, bool enable) {
			if(enable) Enable(mode);
			else Disable(mode);
		}
		public void Enable(int mode) {
			DrawMask |= mode;
			Render();
		}
		public void Disable(int mode) {
			DrawMask &= ~mode;
			Render();
		}
		public void Toggle(int mode) {
			DrawMask ^= mode;
			Render();
		}

		protected bool IsEnabled(int mode) {
			return (DrawMask & mode) > 0;
		}
	}
}
