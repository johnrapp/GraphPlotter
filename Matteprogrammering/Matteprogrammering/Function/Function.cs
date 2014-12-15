using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering
{
	//Abstract base class for all functions
	public abstract class Function
	{
		//Abstract methods, that must be implemented
		public abstract double Value(double x);
		public abstract Function Derive();

		//Calculate tangent at point (x, f(x))
		public Function Tangent(double x) {
			// Calculated using point–slope form (enpunktsform)
			// y - y0 = k(x - x0)
			// y = k(x - x0) + y0
			// y = k*x - k*x0 + y0

			//Where:
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

		//Algebraically calculate derivate at point (x, f(x))
		public double Derivate(double x) {
			return Derive().Value(x);
		}
		//Numerically approximate derivate at point (x, f(x))
		public double ApproximateDerivate(double x) {
			//Calculate by calculating slope of approximated tangent (central differenskvot)

			//y = dy/dx

			//Where:
			//dx = f(x + h) - f(x - h)
			//dy = 2h

			//Lower value will produce better approximation, but might cause rounding-errors
			double h = 0.001;

			double dy = Value(x + h) - Value(x - h),
				   dx = 2 * h;

			return dy / dx;
		}
	}
}
