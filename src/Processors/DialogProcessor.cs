using Draw.src.Model;
using Draw.src.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Draw
{
    public class DialogProcessor : DisplayProcessor
    {
        public DialogProcessor() { }

        private List<Shape> CopyBuffer { get; set; } = new List<Shape>();
        public List<Shape> Selection { get; set; } = new List<Shape>();
        public bool IsDragging { get; set; }
        public PointF LastLocation { get; set; }

        public void AddRectangle(int x = 0, int y = 0)
        {
            Random rnd = new Random();
            x = x == 0 ? rnd.Next(100, 1000) : x;
            y = y == 0 ? rnd.Next(100, 600) : y;

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;

            ShapeList.Add(rect);
        }

        public void AddEllipse(int x = 0, int y = 0)
        {
            Random rnd = new Random();
            x = x == 0 ? rnd.Next(100, 1000) : x;
            y = y == 0 ? rnd.Next(100, 600) : y;

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 200));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        public void AddCircle(int x = 0, int y = 0)
        {
            Random rnd = new Random();
            x = x == 0 ? rnd.Next(100, 1000) : x;
            y = y == 0 ? rnd.Next(100, 600) : y;

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, 100, 100));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        public void AddCircleLines(int x = 0, int y = 0)
        {
            Random rnd = new Random();
            x = x == 0 ? rnd.Next(100, 1000) : x;
            y = y == 0 ? rnd.Next(100, 600) : y;

            CircleLinesShape ellipse = new CircleLinesShape(new Rectangle(x, y, 100, 100));
            ellipse.FillColor = Color.White;

            ShapeList.Add(ellipse);
        }

        public void AddPolygon(int x = 0, int y = 0)
        {
            Random rnd = new Random();
            x = x == 0 ? rnd.Next(100, 1000) : x;
            y = y == 0 ? rnd.Next(100, 600) : y;

            PolygonShape polygon = new PolygonShape(new Rectangle(x, y, 100, 100));
            polygon.FillColor = Color.White;

            ShapeList.Add(polygon);
        }

        public Shape ContainsPoint(PointF point)
        {
            for (int i = ShapeList.Count - 1; i >= 0; i--)
            {
                if (ShapeList[i].Contains(point))
                {
                    return ShapeList[i];
                }
            }
            return null;
        }

        public void TranslateTo(PointF p)
        {
            if (Selection.Count > 0)
            {
                foreach (var item in Selection)
                    item.Location = new PointF(item.Location.X + p.X - LastLocation.X, item.Location.Y + p.Y - LastLocation.Y);

                LastLocation = p;
            }
        }

        public void Rotate(int angle)
        {
            if (Selection.Count > 0)
            {
                foreach (var item in Selection)
                {
                    item.RotateAt(angle);
                }
            }
        }

        public void GroupSelection()
        {
            if (Selection.Count < 2)
                return;

            float minX = float.MaxValue;
            float maxX = float.MinValue;
            float minY = float.MaxValue;
            float maxY = float.MinValue;
            foreach (var item in Selection)
            {
                if (item.Location.X < minX)
                    minX = item.Location.X;

                if (item.Location.X + item.Rectangle.Width > maxX)
                    maxX = item.Location.X + item.Rectangle.Width;

                if (item.Location.Y < minY)
                    minY = item.Location.Y;

                if (item.Location.Y + item.Rectangle.Height > maxY)
                    maxY = item.Location.Y + item.Rectangle.Height;
            }

            GroupShape group = new GroupShape(new RectangleF(minX, minY, maxX - minX, maxY - minY));
            group.Elements = Selection;
            group.IsSelected = true;
            Selection = new List<Shape> { group };

            foreach (var item in group.Elements)
            {
                item.IsSelected = false;
                ShapeList.Remove(item);
            }

            ShapeList.Add(group);
        }

        public void UngroupSelection()
        {
            var groups = Selection.Where(i => i.GetType() == typeof(GroupShape)).Select(i => (GroupShape)i).ToList();

            // Check if there are groups in the selection
            foreach (var item in groups)
            {
                Selection.Remove(item);
                ShapeList.Remove(item);

                var group = (GroupShape)item;

                Selection.AddRange(group.Elements);
                ShapeList.AddRange(group.Elements);
                group.Elements.ForEach(i => i.IsSelected = true);
            }
        }

        public void CopySelection()
        {
            CopyBuffer = new List<Shape>(Selection);
        }

        public void PasteSelection()
        {
            var newElements = SerializationUtils.Copy(CopyBuffer);
            newElements.ForEach(i => i.Location = new PointF(i.Location.X + 50, i.Location.Y + 50));
            ShapeList.AddRange(newElements);
            Selection.ForEach(i => i.IsSelected = false);
            Selection = new List<Shape>(newElements);
            Selection.ForEach(i => i.IsSelected = true);
        }
    }
}
