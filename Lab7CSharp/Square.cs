using System.Drawing;

public class Square : Figure
{
    public int Size { get; set; }

    public Square(int x, int y, int size, Color color) : base(x, y, color)
    {
        Size = size;
    }

    public override void Draw(Graphics g)
    {
        using (Brush b = new SolidBrush(Color))
        {
            g.FillRectangle(b, X, Y, Size, Size);
        }
    }
}
