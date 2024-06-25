using System;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto1_Hilos
{
    public partial class Form1 : Form
    {
        private int numeroTabla = 1;
        private bool procesoActivo = false;
        private Thread procesoTabla;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            // Verificar si el proceso ya está activo
            if (!procesoActivo)
            {
                // Iniciar el proceso en segundo plano para mostrar las tablas automáticamente
                procesoTabla = new Thread(ProcesoMostrarTablas);
                procesoTabla.Start();
                procesoActivo = true;
            }
        }

        private void ProcesoMostrarTablas()
        {
            // Bucle para mostrar las tablas automáticamente
            while (numeroTabla <= 20)
            {
                // Mostrar la tabla de multiplicar actual
                MostrarDatosDataGridView(numeroTabla);

                // Mostrar los números impares del 1 al 20 en el DataGridView de factoriales
                MostrarFactoriales(dataGridViewFactoriales);

                // Mostrar los números pares del 1 al 20 en el DataGridView de potencias
                MostrarPotencias(dataGridViewPotencias);

                // Mostrar los números del 1 al 20 en el DataGridView de números
                MostrarNumeros(dataGridViewNumeros);

                // Incrementar el número de la tabla para la próxima vez
                numeroTabla++;

                // Esperar 1 segundo antes de mostrar la próxima tabla
                Thread.Sleep(1000);
            }

            // Cambiar el valor de procesoActivo de manera segura desde el hilo de la UI
            if (InvokeRequired)
            {
                Invoke(new Action(() => procesoActivo = false));
            }
            else
            {
                procesoActivo = false;
            }
        }

        private void MostrarDatosDataGridView(int numero)
        {
            if (dataGridViewTablas.InvokeRequired)
            {
                // Si estamos en un subproceso diferente al de la interfaz de usuario,
                // utilizamos Invoke para ejecutar el código en el subproceso de la UI.
                Invoke(new Action<int>(MostrarDatosDataGridView), numero);
            }
            else
            {
                // Limpiar los DataGridView
                dataGridViewTablas.Rows.Clear();
                dataGridViewTablas.Columns.Clear();

                // Añadir columnas a los DataGridView
                dataGridViewTablas.Columns.Add("Multiplicacion", "Tabla de Multiplicar");

                // Añadir la cabecera de la tabla de multiplicar
                dataGridViewTablas.Rows.Add($"Tabla del {numero}");

                // Añadir filas con los valores de la tabla de multiplicar
                for (int i = 1; i <= 10; i++)
                {
                    string resultado = $"{numero} x {i} = {numero * i}";
                    dataGridViewTablas.Rows.Add(resultado);
                }
            }
        }

        private void MostrarFactoriales(DataGridView dataGridView)
        {
            if (dataGridView.InvokeRequired)
            {
                // Si estamos en un subproceso diferente al de la interfaz de usuario,
                // utilizamos Invoke para ejecutar el código en el subproceso de la UI.
                Invoke(new Action<DataGridView>(MostrarFactoriales), dataGridView);
            }
            else
            {
                // Limpiar el DataGridView de factoriales
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                // Añadir una columna al DataGridView
                dataGridView.Columns.Add("Factoriales", "Factoriales de los Números Impares");

                // Añadir filas con los factoriales de los números impares del 1 al 20
                for (int i = 1; i <= 20; i += 2)
                {
                    string factorial = $"{i}! = {CalcularFactorial(i)}";
                    dataGridView.Rows.Add(factorial);
                }
            }
        }

        private void MostrarPotencias(DataGridView dataGridView)
        {
            if (dataGridView.InvokeRequired)
            {
                // Si estamos en un subproceso diferente al de la interfaz de usuario,
                // utilizamos Invoke para ejecutar el código en el subproceso de la UI.
                Invoke(new Action<DataGridView>(MostrarPotencias), dataGridView);
            }
            else
            {
                // Limpiar el DataGridView de potencias
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                // Añadir una columna al DataGridView
                dataGridView.Columns.Add("Potencias", "Potencias de los Números Pares");

                // Añadir filas con las potencias de los números pares del 1 al 20
                for (int i = 2; i <= 20; i += 2)
                {
                    double potencia = Math.Pow(i, 2); // Elevar al cuadrado para obtener la potencia
                    string potenciaStr = $"{i}^2 = {potencia}";
                    dataGridView.Rows.Add(potenciaStr);
                }
            }
        }

        private void MostrarNumeros(DataGridView dataGridView)
        {
            if (dataGridView.InvokeRequired)
            {
                // Si estamos en un subproceso diferente al de la interfaz de usuario,
                // utilizamos Invoke para ejecutar el código en el subproceso de la UI.
                Invoke(new Action<DataGridView>(MostrarNumeros), dataGridView);
            }
            else
            {
                // Limpiar el DataGridView de números
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();

                // Añadir una columna al DataGridView
                dataGridView.Columns.Add("Numeros", "Números del 1 al 20");

                // Añadir filas con los números del 1 al 20
                for (int i = 1; i <= 20; i++)
                {
                    dataGridView.Rows.Add(i.ToString());
                }
            }
        }

        private double CalcularFactorial(int n)
        {
            double resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
