using System.Runtime.CompilerServices;
using System.Drawing;
using System.Windows.Forms;

namespace Imgtool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filePath;
        private string filePath1;

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog0 = new OpenFileDialog();
            if (openFileDialog0.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog0.FileName;
                
                
                Bitmap image0 = new Bitmap(filePath);

                label1.Text = $"{image0.Width}x{image0.Height}";

                Image img1 = Image.FromFile(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = img1;
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath1 = openFileDialog1.FileName;

                Bitmap image1 = new Bitmap(filePath1);

                label2.Text = $"{image1.Width}x{image1.Height}";

                Image img2 = Image.FromFile(filePath1);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Image = img2;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Bitmap img1 = new Bitmap(filePath);
            Bitmap img2 = new Bitmap(filePath1);

            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                int matchCount = 0;
                for (int x = 0; x < img1.Width; x++)
                {
                    for (int y = 0; y < img1.Height; y++)
                    {
                        if (img1.GetPixel(x, y) == img2.GetPixel(x, y))
                        {
                            matchCount++;
                        }
                    }
                }
                double matchPercentage = (matchCount / (double)(img1.Width * img1.Height)) * 100;
                label3.Text = $"Match percentage = {matchPercentage}%";
            }
            else
            {
                label3.Text = "Height and width are not equal";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
