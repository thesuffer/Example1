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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        void sign_ago()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/11.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/12.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/13.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/14.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("C:/Users/User/source/repos/Digital_sign/sign/15.png");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_ago();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sign_ago();
        }
    }
}
