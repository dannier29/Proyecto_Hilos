namespace Proyecto1_Hilos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewNumeros = new System.Windows.Forms.DataGridView();
            this.dataGridViewFactoriales = new System.Windows.Forms.DataGridView();
            this.dataGridViewPotencias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTablas = new System.Windows.Forms.DataGridView();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_Numeros = new System.Windows.Forms.TextBox();
            this.TXT_Tipo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNumeros
            // 
            this.dataGridViewNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumeros.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewNumeros.Name = "dataGridViewNumeros";
            this.dataGridViewNumeros.Size = new System.Drawing.Size(164, 295);
            this.dataGridViewNumeros.TabIndex = 0;
            // 
            // dataGridViewFactoriales
            // 
            this.dataGridViewFactoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactoriales.Location = new System.Drawing.Point(224, 137);
            this.dataGridViewFactoriales.Name = "dataGridViewFactoriales";
            this.dataGridViewFactoriales.Size = new System.Drawing.Size(183, 295);
            this.dataGridViewFactoriales.TabIndex = 1;
            // 
            // dataGridViewPotencias
            // 
            this.dataGridViewPotencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPotencias.Location = new System.Drawing.Point(462, 137);
            this.dataGridViewPotencias.Name = "dataGridViewPotencias";
            this.dataGridViewPotencias.Size = new System.Drawing.Size(120, 295);
            this.dataGridViewPotencias.TabIndex = 2;
            // 
            // dataGridViewTablas
            // 
            this.dataGridViewTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablas.Location = new System.Drawing.Point(661, 137);
            this.dataGridViewTablas.Name = "dataGridViewTablas";
            this.dataGridViewTablas.Size = new System.Drawing.Size(131, 295);
            this.dataGridViewTablas.TabIndex = 3;
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.Location = new System.Drawing.Point(476, 472);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(91, 27);
            this.Btn_Iniciar.TabIndex = 4;
            this.Btn_Iniciar.Text = "Ejecutar";
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procesando Números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Procesando Hilos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista de";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número enteros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número Impares";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Factorial de ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Número Pares";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Potencia de ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(704, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(711, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tabla de";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(687, 472);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(91, 27);
            this.btn_Salir.TabIndex = 19;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TXT_Numeros
            // 
            this.TXT_Numeros.Location = new System.Drawing.Point(171, 16);
            this.TXT_Numeros.Name = "TXT_Numeros";
            this.TXT_Numeros.Size = new System.Drawing.Size(62, 20);
            this.TXT_Numeros.TabIndex = 23;
            // 
            // TXT_Tipo
            // 
            this.TXT_Tipo.Location = new System.Drawing.Point(425, 6);
            this.TXT_Tipo.Name = "TXT_Tipo";
            this.TXT_Tipo.Size = new System.Drawing.Size(62, 20);
            this.TXT_Tipo.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 523);
            this.Controls.Add(this.TXT_Tipo);
            this.Controls.Add(this.TXT_Numeros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Iniciar);
            this.Controls.Add(this.dataGridViewTablas);
            this.Controls.Add(this.dataGridViewPotencias);
            this.Controls.Add(this.dataGridViewFactoriales);
            this.Controls.Add(this.dataGridViewNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactoriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNumeros;
        private System.Windows.Forms.DataGridView dataGridViewFactoriales;
        private System.Windows.Forms.DataGridView dataGridViewPotencias;
        private System.Windows.Forms.DataGridView dataGridViewTablas;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TXT_Numeros;
        private System.Windows.Forms.TextBox TXT_Tipo;
    }
}

