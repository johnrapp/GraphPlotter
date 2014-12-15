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

		public override double Value(double x) {
			//y = a*b^x
			return a * Math.Pow(b, x);
		}
		public override Function Derive() {
			//y' = a*ln(b)*b^x

			return new Exponential(a * Math.Log(b), b);
		}

		public override string ToString() {
			//If a == 0, the whole expression will become 0
			if(a == 0) return "0";

			//Add a unless a == 1: turn 1*2^x into 2^x
			//Round a, since a tends to contain a lot of decimals after derivation
			string output = a == 1 ? "" : Math.Round(a, 5) + "*";
			//Add b and the exponent x
			output += b + "^x";

			return output;
		}
	}
}
