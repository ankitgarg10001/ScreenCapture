using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScreenCapture
{
    public partial class Video : Form
    {
        private Bitmap bmp;
        private Graphics gr;

        public Video()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Start";
                pictureBox1.Image = null; ;
            }
            else
            {
                timer1.Start();
                button1.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bmp.Width, bmp.Height));
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

    }
}
