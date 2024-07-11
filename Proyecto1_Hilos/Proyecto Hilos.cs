using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto1_Hilos
{
    public partial class Form1 : Form
    {
        // Declaración de variables de hilos y arreglos estáticos para almacenar resultados
        private Thread hiloFactorial;
        private Thread hiloPotencias;
        private Thread hiloMultiplicar;
        private static long[] factoriales = new long[10];
        private static int[] potencias = new int[10];
        private int indexFactorial = 0;
        private int indexPotencias = 0;

        public Form1()
        {
            InitializeComponent();

            // Eventos de carga y redimensionamiento del formulario
            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
        }

        // Método ejecutado al cargar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial de los DataGridView
            ConfigureDataGridView(dataGridViewNumeros);
            ConfigureDataGridView(dataGridViewTablas);
            ConfigureDataGridView(dataGridViewFactoriales);
            ConfigureDataGridView(dataGridViewPotencias);
        }

        // Método ejecutado al redimensionar el formulario
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Ajuste de la ubicación de los DataGridView al redimensionar
            AdjustDataGridViewLocation(dataGridViewNumeros);
            AdjustDataGridViewLocation(dataGridViewTablas);
            AdjustDataGridViewLocation(dataGridViewFactoriales);
            AdjustDataGridViewLocation(dataGridViewPotencias);
        }

        // Ajusta la ubicación horizontal de un DataGridView en relación al formulario
        private void AdjustDataGridViewLocation(DataGridView dgv)
        {
            dgv.Location = new Point(this.ClientSize.Width - dgv.Width - 10, dgv.Location.Y);
        }

        // Método principal para ejecutar la generación de tablas de multiplicar
        private void Ejecutar()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000); // Espera de 1 segundo
                Invoke((MethodInvoker)delegate
                {
                    // Actualización de datos en la interfaz gráfica mediante Invoke
                    if (i == 1)
                    {
                        dataGridViewNumeros.DataSource = CrearTablaNumeros();
                        ConfigureDataGridView(dataGridViewNumeros);
                    }
                    dataGridViewTablas.DataSource = CrearTablaMultiplicar(i);
                    ConfigureDataGridView(dataGridViewTablas);

                    TXT_Numeros.Text = i.ToString();
                    TXT_Tipo.Text = DeterminarParidad(i);
                });
            }
        }

        // Método para calcular y almacenar factoriales en un hilo separado
        private void VectorFactorial()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000); // Espera de 1 segundo
                if (i % 2 != 0)
                {
                    Invoke(new Action(() =>
                    {
                        TXT_Hilos.Text = hiloFactorial.ManagedThreadId.ToString();
                    }));

                    long factorial = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        factorial *= j;
                    }
                    factoriales[indexFactorial++] = factorial;
                }
            }

            Invoke((MethodInvoker)delegate
            {
                // Actualización de DataGridView con los factoriales calculados
                dataGridViewFactoriales.DataSource = CrearTablaFactorial();
                ConfigureDataGridView(dataGridViewFactoriales);
            });
        }

        // Método para calcular y almacenar potencias en un hilo separado
        private void VectorPotencias()
        {
            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(1000); // Espera de 1 segundo
                if (i % 2 == 0)
                {
                    Invoke(new Action(() =>
                    {
                        TXT_Hilos.Text = hiloPotencias.ManagedThreadId.ToString();
                    }));

                    int potencia = i * i;
                    potencias[indexPotencias++] = potencia;
                }
            }

            Invoke((MethodInvoker)delegate
            {
                // Actualización de DataGridView con las potencias calculadas
                dataGridViewPotencias.DataSource = CrearTablaPotencias();
                ConfigureDataGridView(dataGridViewPotencias);
            });
        }

        // Método para crear una tabla de multiplicar específica
        private DataTable CrearTablaMultiplicar(int n)
        {
            var tablaMultiplicar = new DataTable();
            tablaMultiplicar.Columns.Add("Tabla del " + n);
            for (int i = 1; i <= 10; i++)
            {
                int resultado = n * i;
                tablaMultiplicar.Rows.Add($"{n} * {i} = {resultado}");
            }
            return tablaMultiplicar;
        }

        // Método para crear una tabla con números del 1 al 20
        private DataTable CrearTablaNumeros()
        {
            var tablaNumeros = new DataTable();
            tablaNumeros.Columns.Add("Numero");
            for (int i = 1; i <= 20; i++)
            {
                tablaNumeros.Rows.Add(i);
            }
            return tablaNumeros;
        }

        // Método para crear una tabla con factoriales calculados
        private DataTable CrearTablaFactorial()
        {
            var tablaFactorial = new DataTable();
            tablaFactorial.Columns.Add("Factorial");
            int n = 1;
            foreach (var item in factoriales)
            {
                tablaFactorial.Rows.Add($"{n}! = {item}");
                n += 2;
            }
            return tablaFactorial;
        }

        // Método para crear una tabla con potencias calculadas
        private DataTable CrearTablaPotencias()
        {
            var tablaPotencias = new DataTable();
            tablaPotencias.Columns.Add("Potencia");
            int n = 2;
            foreach (var item in potencias)
            {
                tablaPotencias.Rows.Add($"{n} ^ 2 = {item}");
                n += 2;
            }
            return tablaPotencias;
        }

        // Determina si un número es par o impar
        private string DeterminarParidad(int i)
        {
            return i % 2 == 0 ? "par" : "impar";
        }

        // Configura el modo de ajuste y alineación de columnas en un DataGridView
        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Evento de clic en el botón "Salir" para cerrar la aplicación
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Evento de clic en el botón "Iniciar" para iniciar los hilos de cálculo
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            hiloFactorial = new Thread(VectorFactorial);
            hiloPotencias = new Thread(VectorPotencias);
            hiloMultiplicar = new Thread(Ejecutar);

            hiloFactorial.Start();
            hiloPotencias.Start();
            hiloMultiplicar.Start();
        }
    }
}
