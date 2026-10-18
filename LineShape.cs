using System;
using System.Drawing;

namespace ShapeApp
{
    // ===== ЖИШЭЭ: Шулуун =====
    public class LineShape : Shape
    {
        private readonly bool _down;   // аль диагоналиар татах

        public LineShape(Rectangle b, Color c) : base(b, c)
        {
            _down = Rnd.Next(2) == 0;
        }

        public override string Name { get { return "Шулуун"; } }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            {
                if (_down)
                    g.DrawLine(pen, X, Y, X + Width, Y + Height);
                else
                    g.DrawLine(pen, X, Y + Height, X + Width, Y);
            }
            base.Draw(g);   // суурь классын Draw-г дуудаж нэрийг бичнэ
        }
    }

    // =====================================================================
    // ДААЛГАВАР: LineShape-ийн загвараар дараах классуудыг үүсгэнэ.
    //   Класс бүр Shape-ээс удамшиж, Name болон Draw-г override хийнэ.
    //   Draw-ийн төгсгөлд base.Draw(g)-г дуудна.
    //
    //   Класс           Товч             Graphics-ийн метод
    //   --------------  ---------------  ------------------------------------
    //   RectangleShape  "Тэгш өнцөгт"    DrawRectangle / FillRectangle
    //   CircleShape     "Дугуй"          DrawEllipse   / FillEllipse
    //   PieShape        "Pie"            DrawPie       / FillPie
    //   PolygonShape    "Polygon"        DrawPolygon   / FillPolygon
    //   CurveShape      "Curve"          DrawCurve
    //
    //   Санамж: Pie-д эхлэх өнцөг, хамрах өнцөг; Polygon, Curve-д цэгүүдийн
    //   массив (Point[] эсвэл PointF[]) хэрэгтэй. Эдгээрийг байгуулагч
    //   дотор Rnd ашиглан нэг удаа үүсгэж, талбарт хадгална.
    //
    //   Класс бүрийг тусдаа файлд бичнэ: RectangleShape.cs, CircleShape.cs ...
    // =====================================================================
}
