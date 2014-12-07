using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering
{
	public interface Function
	{
		double Value(double x);
		Function Derive();
		Function Tangent(double x);
	}
}
