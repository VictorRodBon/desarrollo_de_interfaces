using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[,] matriz = new String[10, 3];
        int filaActual = 0;

        String[] matrizAux = new string[10];

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            String valorNombre = nombre.Text;
            String valorDni = dni.Text;
            String valorCantidad = cantidad.Text;

            if (filaActual < matriz.GetLength(0))
            {
                matriz[filaActual, 0] = valorNombre;
                matriz[filaActual, 1] = valorDni;
                matriz[filaActual, 2] = valorCantidad;

                filaActual++;

                nombre.Clear();
                dni.Clear();
                cantidad.Clear();
            }
            else {
                MessageBox.Show("Se ha superado el número máximo de entradas.");
            }

        }

        private void botonCalcularMasDinero_Click(object sender, EventArgs e)
        {
            if (filaActual == 0)
            {
                MessageBox.Show("No hay datos registrados.");
                return;
            }

            string nombreMaximo = "";
            string dniMaximo = "";
            int maxDinero = -1;

            // 1. Recorremos cada fila de la matriz
            for (int i = 0; i < filaActual; i++)
            {
                string dniActual = matriz[i, 1];
                int sumaCliente = 0;

                // 2. Buscamos todas las filas que pertenezcan al mismo DNI y acumulamos su dinero
                for (int j = 0; j < filaActual; j++)
                {
                    if (matriz[j, 1] == dniActual)
                    {
                        if (int.TryParse(matriz[j, 2], out int cantidad))
                        {
                            sumaCliente += cantidad;
                        }
                    }
                }

                // 3. Verificamos si este cliente tiene el acumulado más alto registrado hasta el momento
                if (sumaCliente > maxDinero)
                {
                    maxDinero = sumaCliente;
                    dniMaximo = dniActual;
                    nombreMaximo = matriz[i, 0];
                }
            }

            // 4. Mostramos el resultado final
            masDineroLabel.Text= nombreMaximo + ":" + maxDinero.ToString();
        }


        private void botonCalcularMenosDinero_Click(object sender, EventArgs e)
        {
            if (filaActual == 0)
            {
                MessageBox.Show("No hay datos registrados.");
                return;
            }

            string nombreMinimo = "";
            string dniMinimo = "";
            int minDinero = int.MaxValue; // Empezamos con el valor máximo posible

            // 1. Recorremos cada fila de la matriz
            for (int i = 0; i < filaActual; i++)
            {
                string dniActual = matriz[i, 1];
                int sumaCliente = 0;

                // 2. Acumulamos todos los ingresos del cliente actual
                for (int j = 0; j < filaActual; j++)
                {
                    if (matriz[j, 1] == dniActual)
                    {
                        if (int.TryParse(matriz[j, 2], out int cantidad))
                        {
                            sumaCliente += cantidad;
                        }
                    }
                }

                // 3. Verificamos si este cliente tiene un total menor al registrado hasta ahora
                if (sumaCliente < minDinero)
                {
                    minDinero = sumaCliente;
                    dniMinimo = dniActual;
                    nombreMinimo = matriz[i, 0];
                }
            }

            // 4. Mostramos el resultado
            menosDineroLabel.Text = nombreMinimo+":"+minDinero.ToString();
        }

        private void botonCalcularMayorIngreso_Click(object sender, EventArgs e)
        {
            if (filaActual == 0)
            {
                MessageBox.Show("No hay datos registrados.");
                return;
            }

            int mayor = 0;
            String nombre = "";
            for (int i = 0; i < filaActual; i++)
            {

                int.TryParse(matriz[i, 2], out int resultado);
                if (resultado > mayor)
                {
                    mayor = resultado;
                    nombre= matriz[i, 0];
                }
            }
            maxIngresoLabel.Text = nombre + ":" + mayor.ToString();

        }
    }
}
