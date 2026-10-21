
using System;
using System.Drawing;

namespace ShapeApp
{
    public class PieShape : Shape
    {
        private readonly int _startAngle;
        private readonly int _sweepAngle;

        public PieShape(Rectangle b, Color c) : base(b, c)
        {
            _startAngle = Rnd.Next(0, 360);
            _sweepAngle = Rnd.Next(30, 301);
        }

        public override string Name
        {
            get { return "Pie"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            using (var brush = MakeFill())
            {
                g.FillPie(brush, Bounds, _startAngle, _sweepAngle);
                g.DrawPie(pen, Bounds, _startAngle, _sweepAngle);
            }

            base.Draw(g);
        }
    }
}
