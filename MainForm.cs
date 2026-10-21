using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShapeApp
{
    public partial class MainForm : Form
    {
        private readonly List<Shape> shapes = new List<Shape>();

        public MainForm()
        {
            InitializeComponent();
        }

        // ===== Цэсний үйлдлүүд =====

        private void lineMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new LineShape(b, c));
        }

        private void triangleMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new TriangleShape(b, c));
        }
        // ДААЛГАВАР: Designer дээр "Дүрс" цэсэнд шинэ мөр нэмээд (жишээ нь "Тэгш өнцөгт"),
        // түүн дээр давхар товшиход дараах шиг метод автоматаар үүснэ.
        // Дотор нь өөрийн классаа үүсгэх ганц мөр бичнэ:
        //
        // private void rectangleMenuItem_Click(object sender, EventArgs e)
        // {
        //     AddShape((b, c) => new RectangleShape(b, c));
        // }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            canvas.Invalidate();
        }

        // Санамсаргүй байрлал, хэмжээ, өнгөөр дүрс үүсгэж жагсаалтад нэмнэ
        private void AddShape(Func<Rectangle, Color, Shape> factory)
        {
            var rnd = Shape.Rnd;
            int maxW = Math.Max(40, canvas.ClientSize.Width - 20);
            int maxH = Math.Max(40, canvas.ClientSize.Height - 35);

            int w = rnd.Next(40, Math.Min(160, maxW) + 1);
            int h = rnd.Next(40, Math.Min(160, maxH) + 1);
            int x = rnd.Next(5, Math.Max(6, canvas.ClientSize.Width - w - 5));
            int y = rnd.Next(5, Math.Max(6, canvas.ClientSize.Height - h - 20));

            Color color = Color.FromArgb(rnd.Next(20, 200), rnd.Next(20, 200), rnd.Next(20, 200));

            shapes.Add(factory(new Rectangle(x, y, w, h), color));
            canvas.Invalidate();
        }

        // Полиморфизм: аль төрлийн дүрс болохоос үл хамааран sh.Draw() дуудна.
        // Шинэ класс нэмэхэд энэ кодыг өөрчлөх шаардлагагүй!
        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Shape sh in shapes)
            {
                sh.Draw(e.Graphics);
            }
        }

        private void canvas_Resize(object sender, EventArgs e)
        {
            canvas.Invalidate();
        }

        private void тэгшӨнцөгтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new RectangleShape(b, c));
        }

        private void дугуйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new CircleShape(b, c));
        }

        private void pieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new PieShape(b, c));
        }

        private void олонӨнцөгтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShape((b, c) => new PolygonShape(b, c));
        }
    }
}
