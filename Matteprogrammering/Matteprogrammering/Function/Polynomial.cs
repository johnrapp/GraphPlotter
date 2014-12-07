using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering {
	public class Polynomial : Function {
		//Polynomial function
		//Constants are a list of polynomial constants
		// y = c0*x^0 + c1*x^1 ... + cn*x^n
		//Where c = list of constants
		//Example:
		// y = 5 + 2x + 0*x^2 + x^3
		readonly double[] Constants;
		readonly bool Zero;
		public Polynomial(params double[] constants) {
			Constants = constants;
			//Since constants is readonly, we can cache this
			Zero = constants.Length == 0;
		}
		public double Value(double x) {
			//If constants is empty, return 0, otherwise we will get index out of bounds exceptions
			if(Zero) return 0f;

			// To calculate value:
			//      n
			//y =   ∑ ci*x^i
			//    i = 0

			// Start with first constant, since this isn't affected by x
			// (Math.pow is wasteful if we know that the exponent is 0)
			double value = Constants[0];
			//Skip the first one, since we already used it
			for(int i = 1; i < Constants.Length; i++) {
				// Add constant multiplyed by x raised to i
				// ci*x^i
				value += Constants[i] * Math.Pow(x, i);
			}
			return value;
		}
		public Function Derive() {
			//If constants are empty, the result constants are also empty, so we can reuse this instance
			if(Zero) return this;

			//Derivate is always one degree lower and thereby one term shorter
			double[] DerivateConstants = new double[Constants.Length - 1];
			//Skip the first, since it is to no relevance to the derivate
			for(int i = 1; i < Constants.Length; i++) {
				//Since the new index is one lower, the degree of each term will be lowered by one
				//Multiply by i, since i will equal the exponent
				DerivateConstants[i - 1] = i * Constants[i];
			}
			return new Polynomial(DerivateConstants);
		}

		public Function Tangent(double x) {
			// Calculated using point–slope form (enpunktsform)
			// y - y0 = k(x - x0)
			// y = k(x - x0) + y0
			// y = k*x - k*x0 + y0

			// y0 = y(x)
			// x0 = x
			// k = y'(x)
			Function derivate = this.Derive();
			// Calculate y0
			double y = this.Value(x);
			// Calculate k
			double k = derivate.Value(x);

			// y = a + b*x
			// a = -k*x0 + y0 = y0 - k*x0
			return new Polynomial(y - k * x, k);
		}

		public override string ToString() {
			if(Zero) return "0";

			string[] terms = new string[Constants.Length];

			terms[0] = Constants[0].ToString();

			for(int i = 1; i < Constants.Length; i++) {
				terms[i] = Constants[i] + "*x" + (i > 1 ? "^" + i : "");
			}
			return string.Join(" + ", terms);
		}
	}
}
