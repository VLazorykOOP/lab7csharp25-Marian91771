using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeDrawer
{
    public partial class Form3 : Form
    {
        List<Figure> figures = new List<Figure>();
        Color selectedColor = Color.Black;
        Random rand = new Random();

        public Form3()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(new string[] { "Квадрат", "Прямокутник", "Коло", "Трикутник" });
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSize1.Text, out int size1)) return;
            int size2 = 0;
            if (!string.IsNullOrWhiteSpace(textBoxSize2.Text)) int.TryParse(textBoxSize2.Text, out size2);


            int maxX = Math.Max(0, pictureBox2.Width - 100);
            int maxY = Math.Max(0, pictureBox2.Height - 100);

            int x = rand.Next(0, maxX);
            int y = rand.Next(100, maxY);


            string type = comboBoxType.SelectedItem.ToString();
            Figure f = null;

            switch (type)
            {
                case "Квадрат":
                    f = new Square(x, y, size1, selectedColor);
                    break;
                case "Прямокутник":
                    f = new RectangleFigure(x, y, size1, size2, selectedColor);
                    break;
                case "Коло":
                    f = new Circle(x, y, size1, selectedColor);
                    break;
                case "Трикутник":
                    f = new Triangle(x, y, size1, selectedColor);
                    break;
            }

            if (f != null)
            {
                figures.Add(f);
                Redraw();
            }
        }

        private void Redraw()
        {
            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                foreach (var f in figures)
                    f.Draw(g);
            }
            pictureBox2.Image = bmp;
        }
    }
}
