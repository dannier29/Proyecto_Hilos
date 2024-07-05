using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Hilos
{
    public partial class Form1 : Form
    {
        private int numeroTabla = 1;
        private bool procesoActivo = false;
        private Thread procesoTabla;
        List<int> numerosPares = new List<int>();
        List<int> numerosImpares = new List<int>();
        private int contadorHilos = 0; // Contador para los hilos

        public Form1()
        {
            InitializeComponent();
        }

        private void IdentificarNumeros()
        {
            for (int i = 1; i <= 20; i++)
            {
                Invoke(new Action(() => TXT_Numeros.Text = i.ToString()));
                if (i % 2 == 0)
                {
                    Invoke(new Action(() => TXT_Tipo.Text = "Par"));
                    numerosPares.Add(i);
                }
                else
                {
                    Invoke(new Action(() => TXT_Tipo.Text = "Impar"));
                    numerosImpares.Add(i);
                }

                // Llamar a MostrarTablaMultiplicar en un nuevo hilo
                Thread T = new Thread(() =>
                {
                    MostrarTablaMultiplicar(i);
                 
                });
                T.Start();

                Thread.Sleep(1000); // Demora de 1 segundo
                if (i == 1)
                {
                  

                    Invoke(new Action(() =>
                    {
                        mostrar();
                    }));
                }
            }
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Thread T = new Thread(IdentificarNumeros);
            T.Start();
        }

        private void mostrar()
        {
            Invoke(new Action(() =>
            {

                // Limpiar cualquier contenido previo en dataGridViewNumeros
                dataGridViewNumeros.Rows.Clear();
            dataGridViewNumeros.Columns.Clear();

            // Añadir columna al DataGridView para mostrar los números
            var columnaNumeros = new DataGridViewTextBoxColumn();
            columnaNumeros.Name = "Numeros";
            columnaNumeros.HeaderText = "Números";
            columnaNumeros.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación al centro
            columnaNumeros.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Encabezado centrado
            dataGridViewNumeros.Columns.Add(columnaNumeros);

            // Añadir los números del 1 al 20 a dataGridViewNumeros
            for (int i = 1; i <= 20; i++)
            {
                dataGridViewNumeros.Rows.Add(i.ToString());
            }
            }));

        }

        private void MostrarTablaMultiplicar(int multiplicador)
        {
            Invoke(new Action(() =>
            {
                // Limpiar cualquier contenido previo en dataGridViewTablas
                dataGridViewTablas.Rows.Clear();
                dataGridViewTablas.Columns.Clear();

                // Añadir columna al DataGridView para mostrar la tabla de multiplicar
                var columnaMultiplicacion = new DataGridViewTextBoxColumn();
                columnaMultiplicacion.Name = "Multiplicacion";
                columnaMultiplicacion.HeaderText = $"Tabla del {multiplicador}"; // Encabezado con el número de la tabla
                columnaMultiplicacion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Alineación a la derecha
                columnaMultiplicacion.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Encabezado centrado
                dataGridViewTablas.Columns.Add(columnaMultiplicacion);

                // Configurar el ajuste automático de las columnas
                dataGridViewTablas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Llenar la tabla con los resultados de la multiplicación
                for (int multiplicando = 1; multiplicando <= 10; multiplicando++)
                {
                    int resultado = multiplicador * multiplicando;
                    dataGridViewTablas.Rows.Add($"{multiplicador} x {multiplicando} = {resultado}");
                    if (multiplicador == 20)
                    {
                        Invoke(new Action(() =>
                        {
                            CalcularPotencias();
                            CalcularFactoriales();
                        }));
                    }
                }
            }));

            // Esperar un período de tiempo antes de mostrar la siguiente tabla
            Thread.Sleep(500); // 500 milisegundos = 0.5 segundos
        }

        private void CalcularPotencias()
        {
            Invoke(new Action(() =>
            {
                // Limpiar cualquier contenido previo en dataGridViewPotencias
                dataGridViewPotencias.Rows.Clear();
                dataGridViewPotencias.Columns.Clear();

                // Añadir columna al DataGridView para mostrar las potencias
                var columnaPotencias = new DataGridViewTextBoxColumn();
                columnaPotencias.Name = "Potencias";
                columnaPotencias.HeaderText = "Potencias";
                columnaPotencias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alineación a la derecha
                columnaPotencias.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; // Encabezado centrado
                dataGridViewPotencias.Columns.Add(columnaPotencias);

                // Configurar el ajuste automático de las columnas
                dataGridViewPotencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Mostrar las potencias de los números pares almacenados
                foreach (var numero in numerosPares)
                {
                    // Calcular y mostrar la potencia al cuadrado del número
                    double resultado = Math.Pow(numero, 2);
                    dataGridViewPotencias.Rows.Add($"{numero} ^ 2 = {resultado}");
                }
            }));
        }

        private void CalcularFactoriales()
        {
            Invoke(new Action(() =>
            {
                // Limpiar cualquier contenido previo en dataGridViewFactoriales
                dataGridViewFactoriales.Rows.Clear();
                dataGridViewFactoriales.Columns.Clear();

                // Añadir columna al DataGridView para mostrar los factoriales
                var columnaFactoriales = new DataGridViewTextBoxColumn();
                columnaFactoriales.Name = "Factoriales";
                columnaFactoriales.HeaderText = "Factoriales";
                columnaFactoriales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                columnaFactoriales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Alineación a la izquierda
                dataGridViewFactoriales.Columns.Add(columnaFactoriales);

                // Configurar el ajuste automático de las columnas
                dataGridViewFactoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Mostrar los factoriales de los números impares almacenados
                foreach (var numero in numerosImpares)
                {
                    // Calcular el factorial del número impar
                    long factorial = CalcularFactorial(numero);
                    dataGridViewFactoriales.Rows.Add($"{numero}! = {factorial}");
                }
            }));
        }

        private long CalcularFactorial(int n)
        {
            if (n == 0)
                return 1;

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
