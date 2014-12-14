using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering {
	public class Exponential : Function {
		//Exponential function
		//y = a*b^x
		//y' = a*ln(b)*b^x
		readonly double a, b;
		public Exponential(double a, double b) {
			this.a = a;
			this.b = b;
		}

		public override double[] Constants {
			get {
				return new Double[] {a, b};
			}
		}

		public override double Value(double x) {
			//y = a*b^x
			return a * Math.Pow(b, x);
		}
		public override Function Derive() {
			//y' = a*ln(b)*b^x

			return new Exponential(a * Math.Log(b), b);
		}

		public override string ToString() {
			return String.Format("{0}*{1}^x", a, b);
		}
	}
}
