using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace 圖片美編特效
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image<Bgr, byte> ju;        
        Image<Bgr, byte> blue = null;
        Image<Bgr, byte> green = null;
        Image<Bgr, byte> red = null;
        Size size;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "影像(*.jpg/*.png/*.gif/*.bmp)|*.jpg;*.png;*.gif;*bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var filename = dialog.FileName;

                IntPtr image = CvInvoke.cvLoadImage(filename, Emgu.CV.CvEnum.LOAD_IMAGE_TYPE.CV_LOAD_IMAGE_COLOR);
                size = CvInvoke.cvGetSize(image);
                blue = new Image<Bgr, byte>(size);
                green = new Image<Bgr, byte>(size);
                red = new Image<Bgr, byte>(size);
                ju = new Image<Bgr, byte>(CvInvoke.cvGetSize(image));
                CvInvoke.cvCopy(image, ju, IntPtr.Zero);
                pictureBox1.BackgroundImage = ju.ToBitmap();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        String filenameqq;
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "影像(*.jpg/*.png/*.gif/*.bmp)|*.jpg;*.png;*.gif;*.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filenameqq = dialog.FileName;
                pictureBox1.BackgroundImage.Save(filenameqq);
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;

        }

        public string filename { get; set; }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox13.Visible = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            groupBox12.Visible = true;
            
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void button82_Click(object sender, EventArgs e)
        {
            groupBox15.Visible = true;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            groupBox13.Visible = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            groupBox15.Visible = false;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            groupBox17.Visible = true;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            groupBox17.Visible = false;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            groupBox18.Visible = true;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            groupBox18.Visible = false;
        }

        private void button112_Click(object sender, EventArgs e)
        {
            groupBox21.Visible = true;
        }

        private void button123_Click(object sender, EventArgs e)
        {
            groupBox21.Visible = false;
        }

        private void rGBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox12.Visible = false;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        red.Data[j, i, k] = ju.Data[j, i, 2]; // red
                        green.Data[j, i, k] = ju.Data[j, i, 1]; // green
                        blue.Data[j, i, k] = ju.Data[j, i, 0]; // blue                       
                    }
                }
            }
            pictureBox1.BackgroundImage = red.ToBitmap();
        }

        private void rGBRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox12.Visible = false;
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    red.Data[j, i, 2] = ju.Data[j, i, 2]; // red
                    green.Data[j, i, 1] = ju.Data[j, i, 1]; // green
                    blue.Data[j, i, 0] = ju.Data[j, i, 0]; // blue
                }
            }
            pictureBox1.BackgroundImage = red.ToBitmap();
        }

        private void rGBGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox12.Visible = false;
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    red.Data[j, i, 2] = ju.Data[j, i, 2]; // red
                    green.Data[j, i, 1] = ju.Data[j, i, 1]; // green
                    blue.Data[j, i, 0] = ju.Data[j, i, 0]; // blue
                }
            }
            pictureBox1.BackgroundImage = green.ToBitmap();
        }

        private void rGBBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox12.Visible = false;
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    red.Data[j, i, 2] = ju.Data[j, i, 2]; // red
                    green.Data[j, i, 1] = ju.Data[j, i, 1]; // green
                    blue.Data[j, i, 0] = ju.Data[j, i, 0]; // blue
                }
            }
            pictureBox1.BackgroundImage = blue.ToBitmap();
        }
        private void button70_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button70.BackgroundImage;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = button16.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button17.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button14.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button15.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button12.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button13.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button11.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = button1.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button2.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button3.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button4.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button7.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button8.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button5.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = button6.BackgroundImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button26.BackgroundImage;
        }
       
        int x, y;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Left += e.X - x;
                panel1.Top += e.Y - y;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button27.BackgroundImage;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel2.Left += e.X - x;
                panel2.Top += e.Y - y;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button29.BackgroundImage;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel3.Left += e.X - x;
                panel3.Top += e.Y - y;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button28.BackgroundImage;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button33.BackgroundImage;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button31.BackgroundImage;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button30.BackgroundImage;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button32.BackgroundImage;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button37.BackgroundImage;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button38.BackgroundImage;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button42.BackgroundImage;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button40.BackgroundImage;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button41.BackgroundImage;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button43.BackgroundImage;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button39.BackgroundImage;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button36.BackgroundImage;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button45.BackgroundImage;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button46.BackgroundImage;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button50.BackgroundImage;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button48.BackgroundImage;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button49.BackgroundImage;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button51.BackgroundImage;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button47.BackgroundImage;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button44.BackgroundImage;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button61.BackgroundImage;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button62.BackgroundImage;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button66.BackgroundImage;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button64.BackgroundImage;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button65.BackgroundImage;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button67.BackgroundImage;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button63.BackgroundImage;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button60.BackgroundImage;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button19.BackgroundImage;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button20.BackgroundImage;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button24.BackgroundImage;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button22.BackgroundImage;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button23.BackgroundImage;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button25.BackgroundImage;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button21.BackgroundImage;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button35.BackgroundImage;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button69.BackgroundImage;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            panel2.BackgroundImage = button74.BackgroundImage;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button72.BackgroundImage;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            panel3.BackgroundImage = button73.BackgroundImage;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            panel1.BackgroundImage = button75.BackgroundImage;
        }

    }
}
