
using System;
using System.Drawing;

namespace ShapeApp
{
    public class PolygonShape : Shape
    {
        private readonly Point[] _points;

        public PolygonShape(Rectangle b, Color c) : base(b, c)
        {
            int sides = Rnd.Next(5, 9);
            _points = new Point[sides];

            double centerX = X + Width / 2.0;
            double centerY = Y + Height / 2.0;

            double radiusX = Width / 2.0;
            double radiusY = Height / 2.0;

            for (int i = 0; i < sides; i++)
            {
                double angle = 2 * Math.PI * i / sides
                               - Math.PI / 2;

                int px = (int)(centerX +
                    radiusX * Math.Cos(angle));

                int py = (int)(centerY +
                    radiusY * Math.Sin(angle));

                _points[i] = new Point(px, py);
            }
        }

        public override string Name
        {
            get { return "Олон өнцөгт"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            using (var brush = MakeFill())
            {
                g.FillPolygon(brush, _points);
                g.DrawPolygon(pen, _points);
            }

            base.Draw(g);
        }
    }
}
