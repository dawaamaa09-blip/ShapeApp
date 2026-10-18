using System;
using System.Drawing;

namespace ShapeApp
{
    // ===== Суурь класс =====
    public class Shape
    {
        public static readonly Random Rnd = new Random();

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        public Shape(Rectangle bounds, Color color)
        {
            X = bounds.X;
            Y = bounds.Y;
            Width = bounds.Width;
            Height = bounds.Height;
            Color = color;
        }

        protected Rectangle Bounds
        {
            get { return new Rectangle(X, Y, Width, Height); }
        }

        public virtual string Name
        {
            get { return "Дүрс"; }
        }

        // Виртуал метод: суурь класс дүрсийн нэрийг доор нь бичнэ
        public virtual void Draw(Graphics g)
        {
            using (var brush = new SolidBrush(Color))
            using (var font = new Font("Segoe UI", 8))
            {
                g.DrawString(Name, font, brush, X, Y + Height + 2);
            }
        }

        // Туслах: хүрээ ба дотор будгийн багаж
        protected Pen MakePen() { return new Pen(Color, 2); }
        protected Brush MakeFill() { return new SolidBrush(Color.FromArgb(50, Color)); }
    }
}
