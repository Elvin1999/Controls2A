using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            this.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Downloading ended");
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown1.Value.ToString()));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int width = 50;
            int height = 50;
            pictureBox1.Size = new Size(width * trackBar1.Value, height * trackBar1.Value);
        }

        private void redTrackbar_Scroll(object sender, EventArgs e)
        {
            int red = redTrackbar.Value;
            int green = greenTrackBar.Value;
            int blue = blueTrackbar.Value;

            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
