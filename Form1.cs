using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        
        public string D;
        public string num1;
        public bool num2;
        public Form1()
        {
            num2 = false;
            InitializeComponent();
            textBox1.Text = "0";
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(num2)
            {
                num2 = false;
                textBox1.Text = "0";
            }
            if (textBox1.Text == "0")
                textBox1.Text = bt.Text;
            else
                textBox1.Text += bt.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            D=btn.Text;
            num1= textBox1.Text;
            num2 = true;        
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button24_Click_1(object sender, EventArgs e)
        {
            double result = 0;
            bool q = true;
            double dnum1 = Convert.ToDouble(num1);
            double dnum2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
                result = dnum1 + dnum2;
            if (D == "-")
                result = dnum1 - dnum2;
            if (D == "×")
                result = dnum1 * dnum2;
            if (D == "/")
            {
                if (dnum2 == 0)
                {
                    q = false;

                }
                    
                else
                    result = dnum1 / dnum2;
            }
            if(D=="%")
            {
                result = 100 * dnum1 / dnum2;
            }
            if (D == "=")
            {
                num2 = true;            
            }
            if (q == false)
            {
                textBox1.Text = "На ноль делить нельзя";
                num2 = true;
            }
            else
                textBox1.Text = result.ToString();
            num2 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double dn, res;
            dn=Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text=res.ToString();
            num2 = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn,2);
            textBox1.Text = res.ToString();
            num2 = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
            num2 = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string q=textBox1.Text;
            textBox1.Text += "0";
            textBox1.Text = "-" + q;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) 
            textBox1.Text += ",";        
        }
    }
}
