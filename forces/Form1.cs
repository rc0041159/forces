using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double ascos(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //read force and angle from textboxes
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox1.Text);
                //
                double Fx = Force + cos(Angle);
                double Fy = Force + sin(Angle);
                //d
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy =" + Fy;



            }
            catch
            {

            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
