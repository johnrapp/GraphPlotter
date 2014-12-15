using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matteprogrammering.Extentions;
using System.Diagnostics;

namespace Matteprogrammering {
	public class LineRenderer {
		//Line renderer class to prevent bugs when calling DrawLine and DrawLines with too small or big values

		public static void Render(Graphics g, Pen pen, PointF from, PointF to) {
			g.DrawLine(pen, KeepWithinBounds(from), KeepWithinBounds(to));
		}
		public static void Render(Graphics g, Pen pen, PointF[] points) {
			g.DrawLines(pen, KeepWithinBounds(points));
		}

		//Coordinates has to be clamped in order to prevent exceptions when drawing
		//Minus 1 million to 1 million seems reasonable (Way bigger than any current monitors)
		private const float DRAW_BOUNDS_MIN = -1000000;
		private const float DRAW_BOUNDS_MAX =  1000000;

		private static PointF[] KeepWithinBounds(PointF[] points) {
			for(int i = 0, l = points.Length; i < l; i++) {
				points[i] = KeepWithinBounds(points[i]);
			}
			return points;
		}
		private static PointF KeepWithinBounds(PointF point) {
			return new PointF(
				KeepWithinBounds(point.X),
				KeepWithinBounds(point.Y)
			);
		}
		private static float KeepWithinBounds(float a) {
			return Clamp(a, DRAW_BOUNDS_MAX, DRAW_BOUNDS_MIN);
		}

		private static float Clamp(float value, float max, float min) {
			return (value < min) ? min : (value > max) ? max : value;
		}
	}
}
