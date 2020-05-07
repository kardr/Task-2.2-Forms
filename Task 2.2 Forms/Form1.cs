using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2._2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            char f = ' ';
            if (radioButton1.Checked == true) f = 'к';
            if (radioButton2.Checked == true) f= 'п';
            if (radioButton3.Checked == true) f = 'т';

            switch (f)
            {
                case 'к':
                    {
                        double r = Convert.ToDouble(textBox1.Text);
                        double S;
                        S = Math.PI * Math.Pow(r, 2);
                        textBox7.Text = S.ToString(); ;
                        double P;
                        P = 2 * Math.PI * r;
                        textBox8.Text = P.ToString(); 
                        break;
                    }
                case 'п':
                    {
                        double a = Convert.ToDouble(textBox2.Text);
                        double b = Convert.ToDouble(textBox3.Text);
                        double S;
                        S = a * b;
                        textBox7.Text = S.ToString(); ;
                        double P;
                        P = (a + b) * 2;
                        textBox8.Text = P.ToString();
                        break;
                    }
                case 'т':
                    {
                        double a = Convert.ToDouble(textBox4.Text);
                        double b = Convert.ToDouble(textBox5.Text);
                        double c = Convert.ToDouble(textBox6.Text);
                        double S, p, P;
                        P = a + b + c;
                        p = P / 2;
                        S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        textBox7.Text = S.ToString();
                        textBox8.Text = P.ToString();
                        break;
                    }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

        }
        
    }
}
