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
	public partial class FunctionPicker : UserControl {
		private TextBox[] Inputs;
		public EventHandler OnFunctionChanged;
		private Function function;
		public FunctionPicker() {
			InitializeComponent();

			Inputs = new TextBox[] { ConstantTerm, LinearTerm, QuadraticTerm, CubicTerm };
		}
		public Function Function {
			get { return function; }
			set {
				function = value;
				if(OnFunctionChanged != null) {
					OnFunctionChanged(this, null);
				}
				Render();
			}
		}
		bool hack = false;
		private void Render() {
			hack = true;

			double[] constants = Function.Constants;
			int i = 0;
			for(; i < constants.Length; i++) {
				Inputs[i].Text = Math.Round(constants[i], 1).ToString();
			}
			for(; i < Inputs.Length; i++) {
				Inputs[i].Text = "0";
			}

			hack = false;
		}

		private void OnDerive(object sender, EventArgs e) {
			Function = Function.Derive();
		}

		private void OnTextChange(object sender, EventArgs e) {
			if(hack) return;

			double[] constants = new double[Inputs.Length];

			for(int i = 0; i < constants.Length; i++) {
				if(!double.TryParse(Inputs[i].Text, out constants[i]))
					constants[i] = 0;
			}

			Function = new Polynomial(constants);
		}
	}
}
