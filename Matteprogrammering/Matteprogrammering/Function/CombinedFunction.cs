using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering {
	public class CombinedFunction : Function {
		//Special function that can be used to combine other functions
		//Useful because code to calculate value and derivate of different types of function eg. polynomials and exponentials
			//can be kept in their own classes
		//y = f(x) + g(x)
		//Where f and g are two functions
		//Example:
		//f(x) = x, g(x) = e^x
		//y = x + e^x
		readonly Function[] terms;
		public CombinedFunction(params Function[] terms) {
			this.terms = terms;
		}

		public override double[] Constants {
			get {
				return terms.SelectMany(term => term.Constants).ToArray();
			}
		}

		public override double Value(double x) {
			//Calculate combined value of functions
			return terms.Sum(term => term.Value(x));
		}
		public override Function Derive() {
			//Derivate each function individually
			return new CombinedFunction(terms.Select(term => term.Derive()).ToArray());
		}

		public override string ToString() {
			//Call ToString on each individual function and join with a +
			return string.Join(" + ", terms.Select(term => term.ToString()));
		}
	}
}
