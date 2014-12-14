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
	public partial class GraphViewer : Form {
		private Window Window {
			get { return Graph.Window; }
			set {
				try {
					Graph.Window = value;

					WindowPicker.Window = value;
				} catch(InvalidOperationException ex) { }
			}

		}
		private Function Function {
			get { return Graph.Function; }
			set {
				try {
					Graph.Function = value;

					FunctionPicker.Function = value;

					CurrentFunction.Text = value.ToString();
				} catch(InvalidOperationException ex) { }
			}
		}
		public GraphViewer() {
			InitializeComponent();

			Window = Window.DEFAULT;

			//Function = new Polynomial(0, -2, 0, 1);
			//Function = new Exponential(8, 0.8);
			Function = new CombinedFunction(
				new Polynomial(-8, 3),
				new Exponential(8, 0.8)
			);

			Graph.OnWindowChanged += new EventHandler(OnRenderNewWindow);
			WindowPicker.OnWindowChanged = new EventHandler(OnWindowChanged);

			FunctionPicker.OnFunctionChanged = new EventHandler(OnFunctionChanged);
		}

		bool hack = false;
		private void OnWindowChanged(object sender, EventArgs e) {
			if(hack) return;

			hack = true;
			Graph.Window = WindowPicker.Window;
			hack = false;
		}

		private void OnRenderNewWindow(object sender, EventArgs e) {
			if(hack) return;

			hack = true;
			WindowPicker.Window = Graph.Window;
			hack = false;
		}

		private void OnFunctionChanged(object sender, EventArgs e) {
			Graph.Function = FunctionPicker.Function;
			CurrentFunction.Text = FunctionPicker.Function.ToString();
		}

		private void OnToggleDrawMode(object sender, EventArgs e) {
			CheckBox box = (CheckBox) sender;
			Graph.Toggle((int) box.Tag, box.Checked);
		}


		private void OnSetDisplayMode(object sender, EventArgs e) {
			RadioButton button = (RadioButton) sender;
			Graph.DisplayMode = (DisplayMode) button.Tag;
		}

	}
}
