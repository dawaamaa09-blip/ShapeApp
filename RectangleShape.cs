using System;
using System.Drawing;

namespace ShapeApp
{
    // ===== Тэгш өнцөгт =====
    public class RectangleShape : Shape
    {
        public RectangleShape(Rectangle b, Color c) : base(b, c)
        {
        }

        public override string Name
        {
            get { return "Тэгш өнцөгт"; }
        }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            using (var brush = MakeFill())
            {
                g.FillRectangle(brush, Bounds);   // дотор нь будна
                g.DrawRectangle(pen, Bounds);     // хүрээг зурна
            }
            base.Draw(g);   // нэрийг доор нь бичнэ
        }
    }
}