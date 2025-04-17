using System.Drawing;

public abstract class Figure
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; }

    public Figure(int x, int y, Color color)
    {
        X = x;
        Y = y;
        Color = color;
    }

    public abstract void Draw(Graphics g);
}
