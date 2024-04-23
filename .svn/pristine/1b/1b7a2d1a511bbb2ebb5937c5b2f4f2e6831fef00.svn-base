using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public class EllipseShape : Shape
    {
        public EllipseShape(RectangleF rect) : base(rect) { }

        public EllipseShape(RectangleF rect, Color fillColor, Color strokeColor, int transparency)
            : base(rect, fillColor, strokeColor, transparency) { }

        public override bool Contains(PointF point)
        {
            float x = point.X;
            float y = point.Y;

            float h = Rectangle.X + Rectangle.Width / 2;
            float k = Rectangle.Y + Rectangle.Height / 2;

            float rx = Rectangle.Width / 2;
            float ry = Rectangle.Height / 2;

            return (Math.Pow(x - h, 2) / Math.Pow(rx, 2)) + (Math.Pow(y - k, 2) / Math.Pow(ry, 2)) <= 1;
        }

        public override void DrawSelf(Graphics grfx)
        {
            Color color = Color.FromArgb(Opacity, FillColor);
            Color strokeColor = Color.FromArgb(Opacity, StrokeColor);

            var state = grfx.Save();

            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt(Angle, new PointF(Location.X + Width / 2, Location.Y + Height / 2));
            transformationMatrix.Scale(Scale, Scale);
            grfx.Transform = transformationMatrix;

            grfx.FillEllipse(new SolidBrush(color), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(new Pen(strokeColor, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            base.DrawSelf(grfx);

            grfx.Restore(state);
        }
    }
}
