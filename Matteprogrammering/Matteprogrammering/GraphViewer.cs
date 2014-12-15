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
		public GraphViewer() {
			InitializeComponent();

			//Initialize with default window
			Graph.Window = WindowController.Window = Window.DEFAULT;

			//Attach event listeners
			Graph.OnWindowChanged += new EventHandler(OnRenderNewWindow);
			WindowController.OnWindowChanged = new EventHandler(OnWindowChanged);

			FunctionPicker.OnFunctionChanged = new EventHandler(OnFunctionChanged);
		}

		//Flag wheter or not to ignore event
		bool prevent = false;
		private void OnWindowChanged(object sender, EventArgs e) {
			if(prevent) return;

			prevent = true;
			//Keep the Graph window in sync with the WindowController window
			Graph.Window = WindowController.Window;
			prevent = false;
		}

		private void OnRenderNewWindow(object sender, EventArgs e) {
			if(prevent) return;

			prevent = true;
			//Keep the Graph window in sync with the WindowController window
			WindowController.Window = Graph.Window;
			prevent = false;
		}

		private void OnFunctionChanged(object sender, EventArgs e) {
			//Keep the Graph function in sync with the FunctionPicker function
			Graph.Function = FunctionPicker.Function;
		}

		private void OnToggleDrawMode(object sender, EventArgs e) {
			//Toggle draw flags in Graph
			CheckBox box = (CheckBox) sender;
			Graph.Toggle((int) box.Tag, box.Checked);
		}


		private void OnSetDisplayMode(object sender, EventArgs e) {
			//Set display mode of graph
			RadioButton button = (RadioButton) sender;
			Graph.DisplayMode = (DisplayMode) button.Tag;
		}

	}
}
