using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageInversionApp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "BMP Files|*.bmp";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openDialog.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            Bitmap newImage = new Bitmap(originalImage);

            for (int y = 0; y < newImage.Height; y++)
            {
                for (int x = 0; x < newImage.Width; x++)
                {
                    Color pixel = newImage.GetPixel(x, y);
                    Color inverted;

                    if (radioFullInvert.Checked)
                        inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    else if (radioRedInvert.Checked)
                        inverted = Color.FromArgb(255 - pixel.R, pixel.G, pixel.B);
                    else if (radioGreenInvert.Checked)
                        inverted = Color.FromArgb(pixel.R, 255 - pixel.G, pixel.B);
                    else // radioBlueInvert
                        inverted = Color.FromArgb(pixel.R, pixel.G, 255 - pixel.B);

                    newImage.SetPixel(x, y, inverted);
                }
            }

            pictureBox1.Image = newImage;
            originalImage = newImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "BMP Files|*.bmp";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage.Save(saveDialog.FileName);
            }
        }
    }
}
