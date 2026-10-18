using System;
using System.Drawing;

namespace ShapeApp
{
    // ===== Гурвалжин =====
    public class TriangleShape : Shape
    {
        private readonly Point[] _points;

        public TriangleShape(Rectangle b, Color c) : base(b, c)
        {
            // Bounds доторх гурвалжны 3 орой
            _points = new Point[]
            {
                new Point(X + Width / 2, Y),          // дээд орой
                new Point(X,             Y + Height), // зүүн доод
                new Point(X + Width,     Y + Height)  // баруун доод
            };
        }

        public override string Name
        {
            get { return "Гурвалжин"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            using (var brush = MakeFill())
            {
                g.FillPolygon(brush, _points);   // дотор нь будна
                g.DrawPolygon(pen, _points);     // хүрээг зурна
            }
            base.Draw(g);   // нэрийг доор нь бичнэ
        }
    }
}