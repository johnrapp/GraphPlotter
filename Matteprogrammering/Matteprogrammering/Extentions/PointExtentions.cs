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
	}
}
