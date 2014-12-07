using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matteprogrammering.Extentions;

namespace Matteprogrammering {
	public class Window {
		public static readonly int MIN_X = 0;
		public static readonly int MAX_X = 1;
		public static readonly int MIN_Y = 2;
		public static readonly int MAX_Y = 3;
		public static Window DEFAULT = new Window(-10, 10, -10, 10);

		public readonly PointF Min, Max;

		private Window(PointF min, PointF max) {
			Min = min;
			Max = max;
		}

		public Window(float minX, float maxX, float minY, float maxY) : this(new PointF(minX, minY), new PointF(maxX, maxY)) {
		}
		public Window(float[] bounds) : this(new PointF(bounds[MIN_X], bounds[MIN_Y]), new PointF(bounds[MAX_X], bounds[MAX_Y])) {
		}

		/*
		public PointF Center {
			get {
				//Average of min and max
				return Min.Add(Max).Scale(0.5f);
			}
		}
		*/

		public Boolean Validate() {
			return Min.X < Max.X && Min.Y < Max.Y;
		}
		public float[] Bounds() {
			float[] bounds = new float[4];

			bounds[MIN_X] = Min.X;
			bounds[MAX_X] = Max.X;
			bounds[MIN_Y] = Min.Y;
			bounds[MAX_Y] = Max.Y;

			return bounds;
		}
		public Matrix GetMatrix() {
			/* Development version
			Matrix matrix = new Matrix();

			matrix.Scale(1f / (Max.X - Min.X),
						 1f / (Max.Y - Min.Y));
			
			matrix.Translate(-Min.X, -Min.Y);
			*/

			///* Optimized version:
			float scaleX = 1f / (Max.X - Min.X),
				  scaleY = 1f / (Max.Y - Min.Y);

			Matrix matrix = new Matrix(
				scaleX, 0,
				0, scaleY,
				-Min.X * scaleX,
				-Min.Y * scaleY
			);
			//*/

			return matrix;
		}
		public Window Transform(Matrix matrix) {
			PointF[] bounds = new PointF[] { Min, Max };
			matrix.TransformPoints(bounds);
			return new Window(bounds[0], bounds[1]);
		}
		public Window Translate(float x, float y) {
			/* Development version
			Matrix matrix = new Matrix();
			matrix.Translate(x, y);
			*/

			///* Optimized version:
			Matrix matrix = new Matrix(1, 0, 0, 1, x, y); 
			//*/
			return Transform(matrix);
		}
		public Window Zoom(float factor, bool zoomOut) {
			/* Development version
			Matrix matrix = new Matrix();
			//Scale with factor
			matrix.Scale(factor);
			*/

			///* Optimized version:
			Matrix matrix = new Matrix(factor, 0, 0, factor, 0, 0);
			//*/

			//Invert matrix to zoom out
			if(zoomOut) matrix.Invert();
			
			return Transform(matrix);
		}

		public Window Zoom(float factor, PointF origin, bool zoomOut) {
			/* Development version
			Matrix matrix = new Matrix();
			//Center origin
			matrix.Translate(origin);
			//Scale with factor
			matrix.Scale(factor);
			//Undo centering
			matrix.Translate(origin.Scale(-1));
			*/

			///* Optimized version:
			Matrix matrix = new Matrix(
				factor, 0,
				0, factor,
				origin.X - origin.X * factor,
				origin.Y - origin.Y * factor);
			//*/

			//Invert matrix to zoom out
			if(zoomOut) matrix.Invert();

			return Transform(matrix);
		}

		public static Window operator +(Window window, PointF translation) {
			return window.Translate(translation.X, translation.Y);
		}
		public static Window operator -(Window window, PointF translation) {
			return window.Translate(-translation.X, -translation.Y);
		}
		public static Window operator *(Window window, Matrix transformation) {
			return window.Transform(transformation);
		}
	}
}
