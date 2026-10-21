
using System;
using System.Drawing;

namespace ShapeApp
{
    public class CurveShape : Shape
    {
        private readonly Point[] _points;

        public CurveShape(Rectangle b, Color c) : base(b, c)
        {
            int count = Rnd.Next(4, 8);
            _points = new Point[count];

            for (int i = 0; i < count; i++)
            {
                int px = X + (Width - 1) * i / (count - 1);
                int py = Y + Rnd.Next(Math.Max(1, Height));

                _points[i] = new Point(px, py);
            }
        }

        public override string Name
        {
            get { return "Муруй шугам"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            {
                g.DrawCurve(pen, _points);
            }

            base.Draw(g);
        }
    }
}
