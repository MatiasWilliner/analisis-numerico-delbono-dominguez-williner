
namespace WindowsFormsApp1
{
    partial class FormUnidad4
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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtXi = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.lblXi = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(196, 47);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(121, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtXi
            // 
            this.txtXi.Location = new System.Drawing.Point(196, 73);
            this.txtXi.Name = "txtXi";
            this.txtXi.Size = new System.Drawing.Size(121, 20);
            this.txtXi.TabIndex = 1;
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(196, 99);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(121, 20);
            this.txtXf.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(196, 125);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(637, 70);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 4;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(62, 57);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(45, 13);
            this.lblFuncion.TabIndex = 5;
            this.lblFuncion.Text = "Función";
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Location = new System.Drawing.Point(62, 80);
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(16, 13);
            this.lblXi.TabIndex = 6;
            this.lblXi.Text = "Xi";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(62, 103);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(17, 13);
            this.lblXf.TabIndex = 7;
            this.lblXf.Text = "Xf";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(57, 128);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(129, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad de subintervalos";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(564, 73);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Área";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(539, 277);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(108, 59);
            this.btnRegresar.TabIndex = 11;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(395, 277);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 59);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(62, 32);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 14;
            this.lblMetodo.Text = "Método";
            // 
            // FormUnidad4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 364);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblXf);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.lblFuncion);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtXf);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.txtFuncion);
            this.Name = "FormUnidad4";
            this.Text = "Unidad 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtXi;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.Label lblXi;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMetodo;
    }
}