using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace tp6
{
    public partial class Form1 : Form
    {
        
        float temp;
        Calculadora calculadora = new Calculadora();
        List<Calculadora> ListaCalculadora = new List<Calculadora>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += '8';
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text += '.';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] aux = textBox1.Text.ToCharArray();
            for(int i=0; i<textBox1.Text.Length; i++)
            {
                if(aux[i] == '+' || aux[i] == '-' || aux[i] == '*' || aux[i] == '/')
                {
                    calculadora.Operacion = aux[i];
                    calculadora.Numero1 = float.Parse(textBox1.Text.Remove(aux.Length-1));
                    textBox1.Clear();
                }
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += '1';
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            calculadora.Numero1 = float.Parse(textBox1.Text);
            calculadora.Operacion = '+';
            textBox1.Clear();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calculadora.Numero1 = float.Parse(textBox1.Text);
             calculadora.Operacion = '-';
            textBox1.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            calculadora.Numero1 = float.Parse(textBox1.Text);
            calculadora.Operacion = '*';
            textBox1.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            calculadora.Numero2 = float.Parse(textBox1.Text);

            switch (calculadora.Operacion)
            {
                case '+':
                    calculadora.Resultado = calculadora.suma(calculadora.Numero1, calculadora.Numero2);
                    break;
                case '-':
                    calculadora.Resultado = calculadora.resta(calculadora.Numero1, calculadora.Numero2);
                    break;
                case '*':
                    calculadora.Resultado = calculadora.multi(calculadora.Numero1, calculadora.Numero2);
                    break;
                case '/':
                    calculadora.Resultado = calculadora.div(calculadora.Numero1, calculadora.Numero2);
                    break;
            }
            listBox1.Items.Add(DateTime.Now.ToString() + "    " + calculadora.Numero1 +" " + calculadora.Operacion + " " + calculadora.Numero2 + "------>" + calculadora.Resultado);
            reiniciar();
            textBox1.Text = Convert.ToString(calculadora.Resultado);
            ListaCalculadora.Add(calculadora);


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            reiniciar();


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calculadora.Numero1 = float.Parse(textBox1.Text);
             calculadora.Operacion = '/';
            textBox1.Clear();
        }

        public void reiniciar()
        {
            calculadora.Numero1 = 0;
            calculadora.Numero2 = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedIndex.ToString());
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }


    }
}
