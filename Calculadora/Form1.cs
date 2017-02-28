using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double val1;
        double val2;
        string op;
        double resultado;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ",";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            op = "+";
            val1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            op = "-";
            val1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            op = "X";
            val1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            op = "/";
            val1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            op = "%";
            val1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            //op = "√¯";
            //val1 = Convert.ToDouble(txtDisplay.Text);
            //txtDisplay.Clear();

            double r = double.Parse(txtDisplay.Text);
            r = Math.Sqrt(r);
            txtDisplay.Text = r.ToString();

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToDouble(txtDisplay.Text);
            switch (op)
            {
                case "+":
                    resultado = val1 + val2;
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = val1 - val2;
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "X":
                    resultado = val1 * val2;
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = val1 / val2;
                    txtDisplay.Text = resultado.ToString();
                    break;

      
                default:
                    break;

                


            }
            }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}
