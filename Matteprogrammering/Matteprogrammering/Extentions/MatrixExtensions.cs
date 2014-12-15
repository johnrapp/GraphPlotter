using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteprogrammering.Extentions
{
	public static class MatrixExtensions
	{
		//Some methods i found that the Matrix class lacked
		public static PointF TransformVector(this Matrix matrix, PointF vector)
		{
			PointF[] transform = new PointF[] { vector };
			matrix.TransformVectors(transform);
			return transform[0];
		}
		public static PointF TransformPoint(this Matrix matrix, PointF point)
		{
			PointF[] transform = new PointF[] { point };
			matrix.TransformPoints(transform);
			return transform[0];
		}
		public static void Translate(this Matrix matrix, PointF translation) {
			matrix.Translate(translation.X, translation.Y);
		}
		public static void Scale(this Matrix matrix, float scale) {
			matrix.Scale(scale, scale);
		}
	}
}
