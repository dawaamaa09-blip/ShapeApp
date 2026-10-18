using System;
using System.Drawing;

namespace ShapeApp
{
    // ===== Дугуй =====
    public class CircleShape : Shape
    {
        public CircleShape(Rectangle b, Color c) : base(b, c)
        {
        }

        public override string Name
        {
            get { return "Дугуй"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            using (var brush = MakeFill())
            {
                g.FillEllipse(brush, Bounds);   // дотор нь будна
                g.DrawEllipse(pen, Bounds);     // хүрээг зурна
            }
            base.Draw(g);   // нэрийг доор нь бичнэ
        }
    }
}