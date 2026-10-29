using System;
using System.Drawing;

namespace ShapeApp
{
    public class StarShape : Shape
    {
        public StarShape(Rectangle b, Color c) : base(b, c)
        {
        }

        public override string Name
        {
            get { return "Од"; }
        }

        public override void Draw(Graphics g)
        {
            PointF[] points = new PointF[10];

            float centerX = X + Width / 2f;
            float centerY = Y + Height / 2f;

            float outerRadius = Math.Min(Width, Height) / 2f;
            float innerRadius = outerRadius * 0.4f;

            for (int i = 0; i < 10; i++)
            {
                double angle = -Math.PI / 2 + i * Math.PI / 5;
                float radius = (i % 2 == 0)
                    ? outerRadius : innerRadius;

                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle),
                    centerY + radius * (float)Math.Sin(angle)
                );
            }

            using (Brush brush = MakeFill())
            using (Pen pen = MakePen())
            {
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            base.Draw(g);
        }
    }
}
