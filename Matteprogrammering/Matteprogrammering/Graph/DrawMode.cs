using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering {
	public class DrawMode {
		public const int Function = 1;	  //0001
		public const int Tangent = 1 << 1;//0010
		public const int Trace = 1 << 2;  //0100
	}
}
