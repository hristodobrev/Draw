using System;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public abstract class Shape
    {
        public Shape(RectangleF rect)
        {
            rectangle = rect;
            Name = $"{GetType().Name}-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }
        public Shape(RectangleF rect, Color fillColor, Color strokeColor, int opacity)
        {
            rectangle = rect;
            FillColor = fillColor;
            StrokeColor = strokeColor;
            Opacity = opacity;
            Name = $"{GetType().Name}-{Guid.NewGuid().ToString().Substring(0, 5)}";
        }

        private RectangleF rectangle;
        public virtual RectangleF Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }

        public virtual float Width
        {
            get { return Rectangle.Width; }
            set { rectangle.Width = value; }
        }

        public virtual float Height
        {
            get { return Rectangle.Height; }
            set { rectangle.Height = value; }
        }

        public virtual PointF Location
        {
            get { return Rectangle.Location; }
            set { rectangle.Location = value; }
        }

        public virtual Color FillColor { get; set; } = Color.White;
        public virtual Color StrokeColor { get; set; } = Color.Black;
        public virtual float StrokeWidth { get; set; } = 1;
        public bool IsSelected { get; set; }
        public virtual int Opacity { get; set; } = 255;
        public string Name { get; set; }
        public virtual int Angle { get; set; }
        public virtual float Scale { get; set; } = 1;

        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public virtual void DrawSelf(Graphics grfx)
        {
            if (IsSelected)
            {
                var pen = new Pen(Color.DarkGray, 1);
                pen.DashPattern = new float[] { 5, 10 };

                grfx.DrawRectangle(pen, Rectangle.X - 2, Rectangle.Y - 2, Rectangle.Width + 4, Rectangle.Height + 4);
            }
        }

        public virtual void RotateAt(int angle)
        {
            this.Angle += angle;
        }
    }
}
