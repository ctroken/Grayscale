namespace Grayscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            pictureBox2.Image.Save(saveFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Image);
            Bitmap newImg = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Color c = img.GetPixel(i, j);
                    int gray = (int)((c.R * 0.2) + (c.G * 0.5) + (c.B * 0.2));
                    Color newC = Color.FromArgb(c.A, gray, gray, gray);
                 
                    newImg.SetPixel(i, j, newC);
                }
            }
            pictureBox2.Image = newImg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
