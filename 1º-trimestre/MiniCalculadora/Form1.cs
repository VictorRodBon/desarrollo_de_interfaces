using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int.TryParse(Suma1.Text, out int sum1);
            int.TryParse(Suma2.Text, out int sum2);

            ResultadoSuma.Text = (sum1 + sum2).ToString();

            int.TryParse(Resta1.Text, out int res1);
            int.TryParse(Resta2.Text, out int res2);

            ResultadoResta.Text = (res1 - res2).ToString();

            int.TryParse(Multiplicacion1.Text, out int mul1);
            int.TryParse(Multiplicacion2.Text, out int mul2);

            ResultadoMultiplicacion.Text = (mul1 * mul2).ToString();

            int.TryParse(Division1.Text, out int div1);
            int.TryParse(Division2.Text, out int div2);
            
            ResultadoDivision.Text = (div1 / div2).ToString();
        }
    }
}
