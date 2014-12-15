using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering.UI {
	public class ComboBoxItem {
		public object Value { get; set; }
		public string Text { get; set; }

		public ComboBoxItem(object value, string text) {
			Value = value;
			Text = text;
		}

		public override string ToString() {
			return Text;
		}
	}
}
