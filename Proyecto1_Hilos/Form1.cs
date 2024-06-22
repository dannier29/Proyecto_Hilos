using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto1_Hilos
{
    public partial class Form1 : Form
    {
        private int[] numbers = Enumerable.Range(1, 20).ToArray();
        private int[] factorials;
        private int[] potencias;
        private string[] tables;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViews();
        }

        private void InitializeDataGridViews()
        {
            dataGridViewNumeros.Columns.Add("Números", "Números");
            dataGridViewFactoriales.Columns.Add("Factoriales", "Factoriales");
            dataGridViewPotencias.Columns.Add("Potencias", "Potencias");
            dataGridViewTablas.Columns.Add("Tabla", "Tabla");
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
          
        }

        private void ProcessOddNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    factorials[i] = CalculateFactorial(numbers[i]);
                    DisplayTable(numbers[i]);
                }
            }
        }

        private void ProcessEvenNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    potencias[i] = CalculateSquare(numbers[i]);
                    DisplayTable(numbers[i]);
                }
            }
        }

        private int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private int CalculateSquare(int number)
        {
            return number * number;
        }

        private void DisplayTable(int number)
        {
            string tableHeader = $"Tabla del {number}\n";
            string table = "";
            for (int i = 1; i <= 10; i++)
            {
                table += $"{number} x {i} = {number * i}\n";
            }
            tables[(number - 1) * 10] = tableHeader + table;
        }

        private void PopulateDataGrids()
        {
            dataGridViewNumeros.Rows.Clear();
            dataGridViewFactoriales.Rows.Clear();
            dataGridViewPotencias.Rows.Clear();
            dataGridViewTablas.Rows.Clear();

            // Agregar filas a los DataGridViews
            for (int i = 0; i < numbers.Length; i++)
            {
                dataGridViewNumeros.Rows.Add(numbers[i]);
                dataGridViewFactoriales.Rows.Add(factorials[i]);
                dataGridViewPotencias.Rows.Add(potencias[i]);

                // Verificar si la tabla existe antes de agregarla
                if (tables[i] != null)
                {
                    dataGridViewTablas.Rows.Add(tables[i]);
                }
            }
        }



        private void Btn_Iniciar_Click_1(object sender, EventArgs e)
        {
            factorials = new int[numbers.Length];
            potencias = new int[numbers.Length];
            tables = new string[numbers.Length * 10];

            Thread thread1 = new Thread(ProcessOddNumbers);
            Thread thread2 = new Thread(ProcessEvenNumbers);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            PopulateDataGrids();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
