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
		readonly double[] constants;
		readonly bool Zero;
		public Polynomial(params double[] constants) {
			this.constants = constants;
			//Since constants is readonly, we can cache this
			Zero = constants.Length == 0;
		}

		public override double[] Constants {
			get {
				return constants;
			}
		}

		public override double Value(double x) {
			//If constants is empty, return 0, otherwise we will get index out of bounds exceptions
			if(Zero) return 0f;

			// To calculate value:
			//      n
			//y =   ∑ ci*x^i
			//    i = 0

			// Start with first constant, since this isn't affected by x
			// (Math.pow is wasteful if we know that the exponent is 0)
			double value = constants[0];
			//Skip the first one, since we already used it
			for(int i = 1; i < constants.Length; i++) {
				// Add constant multiplyed by x raised to i
				// ci*x^i
				value += constants[i] * Math.Pow(x, i);
			}
			return value;
		}
		public override Function Derive() {
			//If constants are empty, the result constants are also empty, so we can reuse this instance
			if(Zero) return this;

			//Derivate is always one degree lower and thereby one term shorter
			double[] derivateConstants = new double[constants.Length - 1];
			//Skip the first, since it is to no relevance to the derivate
			for(int i = 1; i < constants.Length; i++) {
				//Since the new index is one lower, the degree of each term will be lowered by one
				//Multiply by i, since i will equal the exponent
				derivateConstants[i - 1] = i * constants[i];
			}
			return new Polynomial(derivateConstants);
		}

		public override string ToString() {
			if(Zero) return "0";

			string[] terms = new string[constants.Length];

			terms[0] = constants[0].ToString();

			for(int i = 1; i < constants.Length; i++) {
				terms[i] = constants[i] + "*x" + (i > 1 ? "^" + i : "");
			}
			return string.Join(" + ", terms);
		}
	}
}
