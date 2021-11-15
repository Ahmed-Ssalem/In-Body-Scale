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
    public partial class Form2 : Form
    {
        public double pw(double l)
        {

            return l - 100;

        }
        public double cb(double w, double l, double a)
        {
            return (((13.75 * w) + (5 * l) - (6.76 * a) + 66) * 1.55);

        }
        public double cbw(double w, double l, double a)
        {
            return (((9.56 * w) + (1.85 * l) - (4.68 * a) + 655) * 1.55);

        }


        public double www(double l, double w)
        {
            return (-2.097 + (0.1069 * l) + (0.2466 * w));

        }
        public double ww(double w, double l, double a)
        {
            return (2.447 - (0.09145 * a) + (0.1074 * l) + (0.3362 * w));

        }
        public double f(double l, double w, double a)
        {
            return (((1.20 * w) + (0.23 * a) - (10.8 - 5.4)) / 10);

        }
        public double fw(double l, double w, double a)
        {
            return (((1.20 * w) + (0.23 * a) - 5.4) / 10);

        }


        public Form2(double l, double w, double a, string g)
        {
            InitializeComponent();
            if (g == "male" || g == "Male")
            { pw1.Text = Convert.ToString(pw(l)); }
            else { pw1.Text = Convert.ToString(pw(l - 10)); }

            if (g == "male" || g == "Male")
            { cb1.Text = Convert.ToString(cb(w, l, a)); }
            else { cb1.Text = Convert.ToString(cbw(w, l, a)); }

            if (g == "male" || g == "Male")
            { water.Text = Convert.ToString(ww(a, l, w)); }
            else { water.Text = Convert.ToString(www(w, l)); }

            if (g == "male" || g == "Male")
            { fat.Text = Convert.ToString(f(a, l, w)); }
            else { fat.Text = Convert.ToString(fw(w, l, a)); }


            if (g == "male" || g == "Male")
            {
                if (a >= 18 && a <= 35) { ms.Text = ("40 : 44 "); }
                else if (a >= 36 && a <= 55) { ms.Text = ("36 : 40 "); }
                else if (a >= 56 && a <= 75) { ms.Text = ("32 : 35 "); }
                else if (a >= 76 && a <= 85) { ms.Text = ("<31 "); }
            }
            else
            {
                if (a >= 18 && a <= 35) { ms.Text = ("31 : 33 "); }
                else if (a >= 36 && a <= 55) { ms.Text = ("29 : 31 "); }
                else if (a >= 56 && a <= 75) { ms.Text = ("27 : 30 "); }
                else if (a >= 76 && a <= 85) { ms.Text = ("<26 "); }


            }
        }



        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
