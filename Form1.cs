using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_Body_Scale
{
    public partial class Form1 : Form
    {
        public double L;
        public double W;
        public double A;
        public string G;

        public Form1()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            length.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            weight.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            age.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            gender.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gender.Text == "male" || gender.Text == "female" || gender.Text == "Male" || gender.Text == "Female")
            {
                L = Convert.ToDouble((length.Text));
                W = Convert.ToDouble((weight.Text));
                A = Convert.ToDouble((age.Text));
                G = ((gender.Text));

                this.Hide();
                Form2 frm = new Form2(L, W, A, G);
                frm.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Error"); }
        }
    }
}
