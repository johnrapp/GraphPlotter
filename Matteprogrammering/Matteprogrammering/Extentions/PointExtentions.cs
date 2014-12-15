using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering.Extentions
{
	public static class PointExtentions
	{
		//Some methods i found that the PointF class lacked
		public static PointF Add(this PointF a, PointF b)
		{
			return new PointF(a.X + b.X, a.Y + b.Y);
		}

		public static PointF Subtract(this PointF a, PointF b)
		{
			return new PointF(a.X - b.X, a.Y - b.Y);
		}
		public static PointF Scale(this PointF a, float s) {
			return new PointF(a.X * s, a.Y * s);
		}

		public static String Render(this PointF a) {
			return String.Format("({0}, {1})", a.X, a.Y);
		}

		public static String Render(this PointF a, int d) {
			return String.Format("({0}, {1})", Math.Round(a.X, d), Math.Round(a.Y, d));
		}
	}
}
