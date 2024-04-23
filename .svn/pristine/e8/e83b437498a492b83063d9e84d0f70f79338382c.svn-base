using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public class CircleLinesShape : Shape
    {
        public CircleLinesShape(RectangleF rect) : base(rect) { }

        public CircleLinesShape(RectangleF rect, Color fillColor, Color strokeColor, int transparency)
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

            DrawLines(grfx);

            base.DrawSelf(grfx);

            grfx.Restore(state);
        }

        private void DrawLines(Graphics grfx)
        {
            var centerPoint = new PointF(Location.X + Width / 2, Location.Y + Height / 2);

            var state = grfx.Save();
            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt(Angle + 45, new PointF(Location.X + Width / 2, Location.Y + Height / 2));
            transformationMatrix.Scale(Scale, Scale);
            grfx.Transform = transformationMatrix;

            grfx.DrawLine(new Pen(Color.FromArgb(Opacity, StrokeColor)), centerPoint.X, centerPoint.Y, Location.X + Width / 2, Location.Y);
            grfx.DrawLine(new Pen(Color.FromArgb(Opacity, StrokeColor)), centerPoint.X, centerPoint.Y, Location.X, Location.Y + Height / 2);
            grfx.DrawLine(new Pen(Color.FromArgb(Opacity, StrokeColor)), centerPoint.X, centerPoint.Y, Location.X + Width / 2, Location.Y + Height);
            grfx.DrawLine(new Pen(Color.FromArgb(Opacity, StrokeColor)), centerPoint.X, centerPoint.Y, Location.X + Width, Location.Y + Height / 2);

            grfx.Restore(state);
        }
    }
}
