
namespace WindowsFormsApp1
{
    partial class FormUnidad3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblCaso = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblAjuste = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(63, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 374);
            this.dataGridView1.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(599, 233);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 35);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(599, 288);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 35);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRango
            // 
            this.txtRango.Location = new System.Drawing.Point(138, 49);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(121, 20);
            this.txtRango.TabIndex = 4;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(545, 66);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(173, 20);
            this.txtCondicion.TabIndex = 5;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(545, 104);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(173, 20);
            this.txtPorcentaje.TabIndex = 6;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(545, 142);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(173, 20);
            this.txtFuncion.TabIndex = 7;
            // 
            // lblCaso
            // 
            this.lblCaso.AutoSize = true;
            this.lblCaso.Location = new System.Drawing.Point(65, 16);
            this.lblCaso.Name = "lblCaso";
            this.lblCaso.Size = new System.Drawing.Size(31, 13);
            this.lblCaso.TabIndex = 8;
            this.lblCaso.Text = "Caso";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(65, 52);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(39, 13);
            this.lblRango.TabIndex = 9;
            this.lblRango.Text = "Rango";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(427, 73);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 10;
            this.lblCondicion.Text = "Condición";
            // 
            // lblAjuste
            // 
            this.lblAjuste.AutoSize = true;
            this.lblAjuste.Location = new System.Drawing.Point(427, 107);
            this.lblAjuste.Name = "lblAjuste";
            this.lblAjuste.Size = new System.Drawing.Size(104, 13);
            this.lblAjuste.TabIndex = 11;
            this.lblAjuste.Text = "Porcentaje de ajuste";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(427, 142);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(45, 13);
            this.lblFuncion.TabIndex = 12;
            this.lblFuncion.Text = "Función";
            // 
            // FormUnidad3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.lblAjuste);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.lblCaso);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.txtRango);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormUnidad3";
            this.Text = "Unidad 3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblCaso;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblAjuste;
        private System.Windows.Forms.Label lblFuncion;
    }
}