using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_sign
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        void sign()
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/1.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/2.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/3.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/4.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/5.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/6.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/7.png");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/8.png");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/9.png");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/10.png");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            //this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sign();
        }
    }
}
