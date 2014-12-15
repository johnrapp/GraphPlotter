using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matteprogrammering.Extentions;
using System.Diagnostics;

namespace Matteprogrammering {
	public abstract partial class BaseGraph : UserControl {
		//Base graph class
		//Keep track of the current function and window
		//aswell as contains functions to draw different things, such as plot functions
		//Since it does not drawing by itself it makes no sense to intantiate and is therefor declared abstract

		private Window window;
		private Function function;
		protected Matrix WindowMatrix = new Matrix(),
						 ScreenMatrix = new Matrix(),
						 Matrix = new Matrix(),
						 Inverse = new Matrix();

		public BaseGraph() {
			InitializeComponent();

			//Default window and graph
			Window = Window.DEFAULT;

			Function = new Polynomial(0, 0, 1);
		}

		public virtual Window Window {
			get { return window; }
			set {
				//Validate window, calcate new matrices and render
				if(value.Validate()) {
					window = value;
					WindowMatrix = value.GetMatrix();

					CreateMatrix();
					Render();
				} else {
					throw new InvalidOperationException();
				}
			}
		}
		public Function Function {
			get { return function; }
			set {
				//Set function and render
				function = value;
				Render();
			}
		}

		protected void Render() {
			Invalidate(false);
		}

		protected override void OnPaint(PaintEventArgs e) {
			Graphics g = e.Graphics;
			DrawAxes(g);
		}

		private void DrawAxes(Graphics g) {
			PointF[] axes = new PointF[] {
                //X-axis
				new PointF(Window.Min.X, 0),
				new PointF(Window.Max.X, 0),
                //Y-axis
			    new PointF(0, Window.Min.Y),
				new PointF(0, Window.Max.Y)
            };
			Matrix.TransformPoints(axes);

			LineRenderer.Render(g, Pens.Blue, axes[0], axes[1]);
			LineRenderer.Render(g, Pens.Blue, axes[2], axes[3]);
		}
		protected void Plot(Function function, Graphics g, Pen pen) {
			//Draw one point per pixel
			PointF[] points = new PointF[Width];
			//How much one pixel represents in window space
			double step = Window.Width / Width;
			//Let the tolerance be 10% of the step
			double tolerance = step * 0.1;

			double minX = Window.Min.X;
			double maxX = Window.Max.X - tolerance;

			//Variable used to push items to array
			int push = -1;
			//Start at minX and iterate until maxX
			//maxX is subtracted with tolerance in order to deal with rounding errors when x is very close to maxX
			for(double x = minX; x < maxX; x += step) {
				//Calculate value and push to array
				double y = function.Value(x);
				points[++push] = new PointF((float) x, (float) y);
			}
			//Transform with matrix
			Matrix.TransformPoints(points);

			LineRenderer.Render(g, pen, points);
		}
		private const float TRACE_SIZE = 6;
		protected void Trace(double x, Graphics g, Pen pen) {
			double y = function.Value(x);

			PointF origin = Matrix.TransformPoint(new PointF((float) x, (float) y));

			PointF[] cross = new PointF[] {
				//From the upper left to the lower right
				new PointF(origin.X - TRACE_SIZE, origin.Y - TRACE_SIZE),
				new PointF(origin.X + TRACE_SIZE, origin.Y + TRACE_SIZE),

				//From the upper right to the lower left
				new PointF(origin.X + TRACE_SIZE, origin.Y - TRACE_SIZE),
				new PointF(origin.X - TRACE_SIZE, origin.Y + TRACE_SIZE)
			};

			LineRenderer.Render(g, pen, cross[0], cross[1]);
			LineRenderer.Render(g, pen, cross[2], cross[3]);
		}

		protected override void OnResize(EventArgs e) {
			CalculateScreenMatrix();
			CreateMatrix();
		}
		private void CalculateScreenMatrix() {
			/* Development version
			ScreenMatrix = new Matrix();
			//Invert y-axis and add height
			ScreenMatrix.Translate(0, Height);
			ScreenMatrix.Scale(Width, -Height);
			*/
			
			///* Optimized version
			ScreenMatrix = new Matrix(
				Width, 0,
				0, -Height,
				0, Height
			);
			//*/
		}
		private void CreateMatrix() {
			//Multiply window-matrix with screen-matrix
			Matrix = WindowMatrix.Clone();
			Matrix.Multiply(ScreenMatrix, MatrixOrder.Append);

			Inverse = Matrix.Clone();
			Inverse.Invert();
		}
	}
}
