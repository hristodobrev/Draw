using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Draw
{
    [Serializable]
    public class RectangleShape : Shape
    {
        public RectangleShape(RectangleF rect) : base(rect) { }

        public RectangleShape(RectangleF rect, Color fillColor, Color strokeColor, int transparency)
            : base(rect, fillColor, strokeColor, transparency) { }

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
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

            grfx.FillRectangle(new SolidBrush(color), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(new Pen(strokeColor, StrokeWidth), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            base.DrawSelf(grfx);

            grfx.Restore(state);
        }
    }
}
