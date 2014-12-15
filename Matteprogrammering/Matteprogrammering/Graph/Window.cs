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
		//Class that that enables a min and max value for x and y to be selected when rendering graphswindow

		//Min and max values for x and y.
		//It makes sense to have a limit, since otherwise you could zoom in or out until the float will overflow
		private const float MAX_WIDTH  = 1000000;
		private const float MAX_HEIGHT = 1000000;
		private const float MIN_WIDTH  = 0.05f;
		private const float MIN_HEIGHT = 0.05f;

		//Indices for bounds array (The numbers are not important)
		public const int MIN_X = 0;
		public const int MAX_X = 1;
		public const int MIN_Y = 2;
		public const int MAX_Y = 3;

		//The default window
		public static readonly Window DEFAULT = new Window(-10, 10, -10, 10);

		public readonly PointF Min, Max;

		private Window(PointF min, PointF max) {
			Min = min;
			Max = max;
		}

		public Window(float minX, float maxX, float minY, float maxY) : this(new PointF(minX, minY), new PointF(maxX, maxY)) {
		}
		public Window(float[] bounds) : this(new PointF(bounds[MIN_X], bounds[MIN_Y]), new PointF(bounds[MAX_X], bounds[MAX_Y])) {
		}

		public float Width {
			get { return Max.X - Min.X; }
		}
		public float Height {
			get { return Max.Y - Min.Y; }
		}

		public Boolean Validate() {
			float width = Width, height = Height;
			//Make sure max is bigger than min
			return width > 0 && height > 0
				//Keep within min and max width and height
				&& width < MAX_WIDTH && height < MAX_HEIGHT
				&& width > MIN_WIDTH && height > MIN_HEIGHT;
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

			//Inversely scale with width and height
			matrix.Scale(1f / Width,
						 1f / Height);
			
			//Translate the origin to the lower-left corner
			matrix.Translate(-Min.X, -Min.Y);
			*/

			///* Optimized version:
			float scaleX = 1f / Width,
				  scaleY = 1f / Height;

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
		public Window Center() {
			/* Development version
			Matrix matrix = new Matrix();
			//Move origin to lower-left corner
			matrix.Translate(
				-Min.X, // 0 - Min.X
				-Min.Y  // 0 - Min.Y
			);
			//Move origin to center
			matrix.Translate(
				-Width / 2,
				-Height / 2
			);
			*/

			///* Optimized version:
			Matrix matrix = new Matrix(
				1, 0,
				0, 1,
				-Min.X - (Max.X - Min.X) / 2,
				-Min.Y - (Max.Y - Min.Y) / 2
			);
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
			//Inspired by the Google Maps zoom

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
				origin.Y - origin.Y * factor
			);
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
