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

namespace Matteprogrammering {
	public partial class Graph : UserControl {
		private Window window;
		private Function function;
		protected Matrix WindowMatrix = new Matrix(),
						 ScreenMatrix = new Matrix(),
						 Matrix = new Matrix(),
						 Inverse = new Matrix();

		double tangentX = 0;

		public Graph() {
			InitializeComponent();

			//Default window and graph
			Window = Window.DEFAULT;

			Function = new Polynomial(0, 0, 1);
		}

		public virtual Window Window {
			get { return window; }
			set {
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
				function = value;
				Render();
			}
		}

		private void Render() {
			Invalidate(false);
		}

		protected override void OnPaint(PaintEventArgs e) {
			Graphics g = e.Graphics;
			DrawAxes(g);

			Plot(Function, g, Pens.Black);

			//Function tangent = CurrentFunction.Tangent(tangentX);
			//Plot(tangent, g, Pens.Red);
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

			g.DrawLine(Pens.Blue, axes[0], axes[1]);
			g.DrawLine(Pens.Blue, axes[2], axes[3]);
		}
		private void Plot(Function function, Graphics g, Pen pen) {
			PointF[] points = new PointF[100];
			double minX = Math.Round((double) Window.Min.X),
				   maxX = Math.Round((double) Window.Max.X);
			double step = (maxX - minX) / 100.0;

			int i = -1;
			for(double x = minX; x < maxX - step; x += step) {
				double y = function.Value(x);
				points[++i] = new PointF((float) x, (float) y);
			}
			Matrix.TransformPoints(points);

			g.DrawLines(pen, points);
		}
		protected override void OnResize(EventArgs e) {
			CalculateScreenMatrix();
			CreateMatrix();
		}
		private void CalculateScreenMatrix() {
			/* Development version
			ScreenMatrix = new Matrix();
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
			/* Development version
			Matrix.Reset();
			Matrix.Multiply(WindowMatrix, MatrixOrder.Append);
			Matrix.Multiply(ScreenMatrix, MatrixOrder.Append);
			*/

			///* Optimized version
			Matrix = WindowMatrix.Clone();
			Matrix.Multiply(ScreenMatrix, MatrixOrder.Append);
			//*/

			Inverse = Matrix.Clone();
			Inverse.Invert();
		}
	}
}
