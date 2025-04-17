using System.Drawing;

public class Circle : Figure
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius, Color color) : base(x, y, color)
    {
        Radius = radius;
    }

    public override void Draw(Graphics g)
    {
        using (Brush b = new SolidBrush(Color))
        {
            g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
        }
    }
}
