using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public class PolygonShape : Shape
    {
        private PointF[] Vertices { get; set; }

        public PolygonShape(RectangleF rect) : base(rect) { }

        public PolygonShape(RectangleF rect, Color fillColor, Color strokeColor, int transparency)
            : base(rect, fillColor, strokeColor, transparency) { }

        public override bool Contains(PointF point)
        {
            double minX = this.Vertices[0].X;
            double maxX = this.Vertices[0].X;
            double minY = this.Vertices[0].Y;
            double maxY = this.Vertices[0].Y;
            for (int i = 1; i < this.Vertices.Length; i++)
            {
                PointF q = this.Vertices[i];
                minX = Math.Min(q.X, minX);
                maxX = Math.Max(q.X, maxX);
                minY = Math.Min(q.Y, minY);
                maxY = Math.Max(q.Y, maxY);
            }

            if (point.X < minX || point.X > maxX || point.Y < minY || point.Y > maxY)
            {
                return false;
            }

            bool inside = false;
            for (int i = 0, j = this.Vertices.Length - 1; i < this.Vertices.Length; j = i++)
            {
                if ((this.Vertices[i].Y > point.Y) != (this.Vertices[j].Y > point.Y) &&
                     point.X < (this.Vertices[j].X - this.Vertices[i].X) * (point.Y - this.Vertices[i].Y) / (this.Vertices[j].Y - this.Vertices[i].Y) + this.Vertices[i].X)
                {
                    inside = !inside;
                }
            }

            return inside;
        }

        public override void DrawSelf(Graphics grfx)
        {
            this.Vertices = CalculateVertices(5, Width / 2, new PointF(Location.X, Location.Y));

            Color fillColor = Color.FromArgb(Opacity, FillColor);
            Color strokeColor = Color.FromArgb(Opacity, StrokeColor);

            var state = grfx.Save();

            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt(Angle, new PointF(Location.X + Width / 2, Location.Y + Height / 2));
            transformationMatrix.Scale(Scale, Scale);
            grfx.Transform = transformationMatrix;

            grfx.FillPolygon(new SolidBrush(fillColor), this.Vertices);
            grfx.DrawPolygon(new Pen(strokeColor, StrokeWidth), this.Vertices);

            base.DrawSelf(grfx);

            grfx.Restore(state);
        }

        private PointF[] CalculateVertices(int sides, float sideLength, PointF firstPoint)
        {
            var points = new PointF[sides];
            var deg = (180.0 * (sides - 2)) / sides;
            var step = 360.0 / sides;
            var rad = deg * (Math.PI / 180);

            double sinDeg = Math.Sin(rad);
            double cosDeg = Math.Cos(rad);

            points[0] = firstPoint;

            for (int i = 1; i < points.Length; i++)
            {
                double x = points[i - 1].X - cosDeg * sideLength;
                double y = points[i - 1].Y - sinDeg * sideLength;
                points[i] = new PointF((float)x, (float)y);

                deg -= step;
                rad = deg * (Math.PI / 180);

                sinDeg = Math.Sin(rad);
                cosDeg = Math.Cos(rad);
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += Width * 0.75f;
                points[i].Y += Width * 0.875f;
            }

            return points;
        }
    }
}
