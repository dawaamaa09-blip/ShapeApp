
using System.Drawing;

namespace ShapeApp
{
    public class ArcShape : Shape
    {
        public ArcShape(Rectangle b, Color c) : base(b, c)
        {
        }

        public override string Name
        {
            get { return "Нум"; }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = MakePen())
            {
                g.DrawArc(pen, Bounds, 0, 180);
            }

            base.Draw(g);
        }
    }
}
