using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw.src.Model
{
    [Serializable]
    public class GroupShape : Shape
    {
        public List<Shape> Elements { get; set; } = new List<Shape>();

        public GroupShape(RectangleF rect) : base(rect) { }

        public GroupShape(RectangleF rect, Color fillColor, Color strokeColor, int transparency)
            : base(rect, fillColor, strokeColor, transparency) { }

        public override PointF Location
        {
            get { return Rectangle.Location; }
            set
            {
                foreach (var element in Elements)
                {
                    element.Location = new PointF(
                        element.Location.X - Location.X + value.X,
                        element.Location.Y - Location.Y + value.Y
                    );
                }

                base.Location = value;
            }
        }

        public override Color FillColor
        {
            get { return base.FillColor; }
            set
            {
                foreach (var item in Elements)
                    item.FillColor = value;

                base.FillColor = value;
            }
        }

        public override int Opacity
        {
            get { return base.Opacity; }
            set
            {
                foreach (var item in Elements)
                    item.Opacity = value;

                base.Opacity = value;
            }
        }

        public override float StrokeWidth
        {
            get { return base.StrokeWidth; }
            set
            {
                foreach (var item in Elements)
                    item.StrokeWidth = value;

                base.StrokeWidth = value;
            }
        }

        public override int Angle
        {
            get => base.Angle;
            set
            {
                foreach (var item in Elements)
                    item.Angle = Angle;

                base.Angle = value;
            }
        }

        public override float Scale
        {
            get => base.Scale;
            set
            {
                foreach (var item in Elements)
                    item.Scale = value;

                base.Scale = value;
            }
        }

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
                foreach (var item in Elements)
                    if (item.Contains(point))
                        return true;

            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (var item in Elements)
                item.DrawSelf(grfx);
        }

        public override void RotateAt(int angle)
        {
            foreach (var item in Elements)
                item.RotateAt(angle);
        }
    }
}
