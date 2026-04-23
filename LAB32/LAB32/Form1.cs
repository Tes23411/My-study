using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private int i = -1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void previous_Click(object sender, EventArgs e)
        {
            --i;
            i = i % 3;
            pictureBox1.Image = imageListCafe.Images[Math.Abs(i)];
        }


        private void next_Click_1(object sender, EventArgs e)
        {
            ++i;
            i = i % 3;
            pictureBox1.Image = imageListCafe.Images[i];
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void changeBg_Click(object sender, EventArgs e)
        {

        }
    }
}
