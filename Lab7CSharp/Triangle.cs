using System.Drawing;

public class Triangle : Figure
{
    public int Size { get; set; }

    public Triangle(int x, int y, int size, Color color) : base(x, y, color)
    {
        Size = size;
    }

    public override void Draw(Graphics g)
    {
        using (Brush b = new SolidBrush(Color))
        {
            Point[] points = new Point[]
            {
                new Point(X, Y + Size),
                new Point(X + Size / 2, Y),
                new Point(X + Size, Y + Size)
            };
            g.FillPolygon(b, points);
        }
    }
}
