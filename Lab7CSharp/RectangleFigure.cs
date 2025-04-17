using System.Drawing;

public class RectangleFigure : Figure
{
    public int Width { get; set; }
    public int Height { get; set; }

    public RectangleFigure(int x, int y, int width, int height, Color color) : base(x, y, color)
    {
        Width = width;
        Height = height;
    }

    public override void Draw(Graphics g)
    {
        using (Brush b = new SolidBrush(Color))
        {
            g.FillRectangle(b, X, Y, Width, Height);
        }
    }
}
