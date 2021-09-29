
namespace WindowsFormsApp1
{
    partial class FormUnidad2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(72, 25);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 1;
            this.lblMetodo.Text = "Método";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(287, 24);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(56, 13);
            this.lblDimension.TabIndex = 2;
            this.lblDimension.Text = "Dimensión";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(486, 21);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(151, 50);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(645, 21);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(151, 50);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(349, 21);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(105, 20);
            this.txtDimension.TabIndex = 5;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(646, 77);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(151, 50);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 262);
            this.panel1.TabIndex = 7;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(125, 60);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(117, 20);
            this.txtIteraciones.TabIndex = 8;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(349, 60);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(105, 20);
            this.txtTolerancia.TabIndex = 9;
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(275, 63);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(57, 13);
            this.lblTolerancia.TabIndex = 10;
            this.lblTolerancia.Text = "Tolerancia";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(59, 63);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(59, 13);
            this.lblIteraciones.TabIndex = 11;
            this.lblIteraciones.Text = "Iteraciones";
            // 
            // FormUnidad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 377);
            this.ControlBox = false;
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.lblTolerancia);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblDimension);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormUnidad2";
            this.Text = "Unidad 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblIteraciones;
    }
}