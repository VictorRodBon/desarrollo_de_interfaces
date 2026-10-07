using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<char> operadores = new List<char> { '+', '-', '*', '/' };
        int num1 = 0;
        int num2 = 0;
        String opp = "";


        public void addToResult(object sender, EventArgs e) {
            
            if (verificarTamanioResult()) {
                Button miBoton = (Button)sender;
                if (result.Text == "0" || operadores.Contains(result.Text[result.Text.Length - 1]))
                {
                    result.Text = miBoton.Text;
                }
                else { 
                    result.Text += miBoton.Text;
                }
            }
        }

        public Boolean verificarTamanioResult()
        {
            return result.Text.Length < 10;
        }

        public int calcular(int num1, int num2, string ops) {
            int resultado = 0;
            switch (ops)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num1 == 0 || num2 == 0) { 
                        resultado = 0;
                        MessageBox.Show("Pero tu eres tonto??");
                        num1 = 0;
                        num2 = 0;
                        opp = "";
                        result.Text = "0";
                        break;
                    }
                    else
                    {
                        resultado = num1 / num2;
                        break;
                    }
            }

            return resultado;
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(result.Text);
            
            result.Text = calcular(num1, num2, opp).ToString();
        }

        private void setNum1AndOpp(object sender, EventArgs e)
        {
            Button miBoton = (Button)sender;
            num1 = int.Parse(result.Text);
            opp=miBoton.Text;
            result.Text += opp;
        }

        private void borrar(object sender, MouseEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            
            opp = "";

            result.Text = "0";
        }
    }
}
