using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora6
{
    public partial class Form1 : Form
    {
        string operador;
        int a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txt_valor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_adicao.Text;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;
            }

        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_subtracao;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txt_valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_multiplicacao;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToInt32(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txt_valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_divisao;
                a = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a + Convert.ToInt32(txt_valor.Text));
            }
           else if (operador == "-")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a - Convert.ToInt32(txt_valor.Text));
            }

            else if (operador == "*")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a * Convert.ToInt32(txt_valor.Text));
            }

            else if (operador == "/")
            {
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a / Convert.ToInt32(txt_valor.Text));
            }
        }
    }
}
