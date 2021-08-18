
namespace WindowsFormsApp1
{
    partial class FormUnidad1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrimerValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.lblCargaIteraciones = new System.Windows.Forms.Label();
            this.lblTolerancia = new System.Windows.Forms.Label();
            this.lblConvergente = new System.Windows.Forms.Label();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblResultadoComentario = new System.Windows.Forms.Label();
            this.lblResultadoError = new System.Windows.Forms.Label();
            this.lblResultadoIteraciones = new System.Windows.Forms.Label();
            this.lblResultadoRaiz = new System.Windows.Forms.Label();
            this.lblResultadoConvergente = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtPrimerValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(198, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(123, 37);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(327, 273);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(123, 37);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Función";
            // 
            // lblPrimerValor
            // 
            this.lblPrimerValor.AutoSize = true;
            this.lblPrimerValor.Location = new System.Drawing.Point(45, 122);
            this.lblPrimerValor.Name = "lblPrimerValor";
            this.lblPrimerValor.Size = new System.Drawing.Size(62, 13);
            this.lblPrimerValor.TabIndex = 3;
            this.lblPrimerValor.Text = "Primer valor";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Location = new System.Drawing.Point(44, 152);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(76, 13);
            this.lblSegundoValor.TabIndex = 4;
            this.lblSegundoValor.Text = "Segundo valor";
            // 
            // lblCargaIteraciones
            // 
            this.lblCargaIteraciones.AutoSize = true;
            this.lblCargaIteraciones.Location = new System.Drawing.Point(45, 184);
            this.lblCargaIteraciones.Name = "lblCargaIteraciones";
            this.lblCargaIteraciones.Size = new System.Drawing.Size(73, 13);
            this.lblCargaIteraciones.TabIndex = 5;
            this.lblCargaIteraciones.Text = "N° iteraciones";
            // 
            // lblTolerancia
            // 
            this.lblTolerancia.AutoSize = true;
            this.lblTolerancia.Location = new System.Drawing.Point(46, 217);
            this.lblTolerancia.Name = "lblTolerancia";
            this.lblTolerancia.Size = new System.Drawing.Size(57, 13);
            this.lblTolerancia.TabIndex = 6;
            this.lblTolerancia.Text = "Tolerancia";
            // 
            // lblConvergente
            // 
            this.lblConvergente.AutoSize = true;
            this.lblConvergente.Location = new System.Drawing.Point(415, 94);
            this.lblConvergente.Name = "lblConvergente";
            this.lblConvergente.Size = new System.Drawing.Size(68, 13);
            this.lblConvergente.TabIndex = 7;
            this.lblConvergente.Text = "Convergente";
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Location = new System.Drawing.Point(415, 156);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(30, 13);
            this.lblRaiz.TabIndex = 8;
            this.lblRaiz.Text = "Raíz";
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(415, 188);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(73, 13);
            this.lblIteraciones.TabIndex = 9;
            this.lblIteraciones.Text = "N° iteraciones";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(415, 221);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(87, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error equivalente";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(415, 126);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 11;
            this.lblComentario.Text = "Comentario";
            // 
            // lblResultadoComentario
            // 
            this.lblResultadoComentario.AutoSize = true;
            this.lblResultadoComentario.Location = new System.Drawing.Point(533, 126);
            this.lblResultadoComentario.Name = "lblResultadoComentario";
            this.lblResultadoComentario.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoComentario.TabIndex = 16;
            // 
            // lblResultadoError
            // 
            this.lblResultadoError.AutoSize = true;
            this.lblResultadoError.Location = new System.Drawing.Point(533, 221);
            this.lblResultadoError.Name = "lblResultadoError";
            this.lblResultadoError.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoError.TabIndex = 15;
            // 
            // lblResultadoIteraciones
            // 
            this.lblResultadoIteraciones.AutoSize = true;
            this.lblResultadoIteraciones.Location = new System.Drawing.Point(533, 188);
            this.lblResultadoIteraciones.Name = "lblResultadoIteraciones";
            this.lblResultadoIteraciones.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoIteraciones.TabIndex = 14;
            // 
            // lblResultadoRaiz
            // 
            this.lblResultadoRaiz.AutoSize = true;
            this.lblResultadoRaiz.Location = new System.Drawing.Point(533, 156);
            this.lblResultadoRaiz.Name = "lblResultadoRaiz";
            this.lblResultadoRaiz.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoRaiz.TabIndex = 13;
            // 
            // lblResultadoConvergente
            // 
            this.lblResultadoConvergente.AutoSize = true;
            this.lblResultadoConvergente.Location = new System.Drawing.Point(533, 94);
            this.lblResultadoConvergente.Name = "lblResultadoConvergente";
            this.lblResultadoConvergente.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoConvergente.TabIndex = 12;
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(135, 87);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(88, 20);
            this.txtFuncion.TabIndex = 17;
            // 
            // txtPrimerValor
            // 
            this.txtPrimerValor.Location = new System.Drawing.Point(135, 119);
            this.txtPrimerValor.Name = "txtPrimerValor";
            this.txtPrimerValor.Size = new System.Drawing.Size(88, 20);
            this.txtPrimerValor.TabIndex = 18;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(135, 152);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(88, 20);
            this.txtSegundoValor.TabIndex = 19;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(135, 184);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(88, 20);
            this.txtIteraciones.TabIndex = 20;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(135, 214);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(88, 20);
            this.txtTolerancia.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(45, 38);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 23;
            this.lblMetodo.Text = "Método";
            // 
            // FormUnidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 322);
            this.ControlBox = false;
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtIteraciones);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimerValor);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.lblResultadoComentario);
            this.Controls.Add(this.lblResultadoError);
            this.Controls.Add(this.lblResultadoIteraciones);
            this.Controls.Add(this.lblResultadoRaiz);
            this.Controls.Add(this.lblResultadoConvergente);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.lblRaiz);
            this.Controls.Add(this.lblConvergente);
            this.Controls.Add(this.lblTolerancia);
            this.Controls.Add(this.lblCargaIteraciones);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimerValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FormUnidad1";
            this.Text = "Unidad 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrimerValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Label lblCargaIteraciones;
        private System.Windows.Forms.Label lblTolerancia;
        private System.Windows.Forms.Label lblConvergente;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblResultadoComentario;
        private System.Windows.Forms.Label lblResultadoError;
        private System.Windows.Forms.Label lblResultadoIteraciones;
        private System.Windows.Forms.Label lblResultadoRaiz;
        private System.Windows.Forms.Label lblResultadoConvergente;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtPrimerValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMetodo;
    }
}