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
		public EventHandler OnFunctionChanged;
		private Function function;
		private Function[] Functions = new Function[] {
			new Polynomial(5, -1),
			new Exponential(1, 1.2),
			new CombinedFunction(
				new Polynomial(10, 0, 2, 1),
				new Exponential(1, 2)
			),
			new Polynomial(0, -2, 0, 1, -1, 2, 0.5, -0.5)
		};
		//private ComboBoxItem OtherItem = new ComboBoxItem(new Polynomial(0), "Other");
		private ComboBoxItem OtherItem = new ComboBoxItem(null, "Other");
		public FunctionPicker() {
			InitializeComponent();

			foreach(Function function in Functions) {
				ComboBoxItem item = new ComboBoxItem(function, function.ToString());
				FunctionSelect.Items.Add(item);
			}
		}

		private void OnLoad(object sender, EventArgs e) {
			FunctionSelect.SelectedIndex = 0;
		}

		public Function Function {
			get { return function; }
			set {
				//Prevent windows forms bug
				if(value == null) return;

				function = value;
				FunctionLabel.Text = function.ToString();

				if(OnFunctionChanged != null) {
					OnFunctionChanged(this, null);
				}
			}
		}
		private void OnDerive(object sender, EventArgs e) {
			Function derivate = Function.Derive();
			OtherItem.Value = derivate;

			if(!FunctionSelect.Items.Contains(OtherItem)) {
				FunctionSelect.Items.Add(OtherItem);
				FunctionSelect.SelectedItem = OtherItem;
			}

			Function = derivate;
		}

		private void OnSelectFunction(object sender, EventArgs e) {
			ComboBoxItem item = (ComboBoxItem) FunctionSelect.SelectedItem;
			Function function = (Function) item.Value;

			if(item != OtherItem) {
				FunctionSelect.Items.Remove(OtherItem);
			}
			
			Function = function;	
		}

	}
}
