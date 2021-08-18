
namespace WindowsFormsApp1
{
    partial class FormInicio
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
            this.btnUnidad1 = new System.Windows.Forms.Button();
            this.btnUnidad2 = new System.Windows.Forms.Button();
            this.btnUnidad3 = new System.Windows.Forms.Button();
            this.btnUnidad4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnidad1
            // 
            this.btnUnidad1.Location = new System.Drawing.Point(145, 82);
            this.btnUnidad1.Name = "btnUnidad1";
            this.btnUnidad1.Size = new System.Drawing.Size(298, 49);
            this.btnUnidad1.TabIndex = 0;
            this.btnUnidad1.Text = "Unidad 1";
            this.btnUnidad1.UseVisualStyleBackColor = true;
            this.btnUnidad1.Click += new System.EventHandler(this.btnUnidad1_Click);
            // 
            // btnUnidad2
            // 
            this.btnUnidad2.Location = new System.Drawing.Point(145, 137);
            this.btnUnidad2.Name = "btnUnidad2";
            this.btnUnidad2.Size = new System.Drawing.Size(298, 49);
            this.btnUnidad2.TabIndex = 1;
            this.btnUnidad2.Text = "Unidad 2";
            this.btnUnidad2.UseVisualStyleBackColor = true;
            this.btnUnidad2.Click += new System.EventHandler(this.btnUnidad2_Click);
            // 
            // btnUnidad3
            // 
            this.btnUnidad3.Location = new System.Drawing.Point(145, 192);
            this.btnUnidad3.Name = "btnUnidad3";
            this.btnUnidad3.Size = new System.Drawing.Size(298, 49);
            this.btnUnidad3.TabIndex = 2;
            this.btnUnidad3.Text = "Unidad 3";
            this.btnUnidad3.UseVisualStyleBackColor = true;
            // 
            // btnUnidad4
            // 
            this.btnUnidad4.Location = new System.Drawing.Point(145, 247);
            this.btnUnidad4.Name = "btnUnidad4";
            this.btnUnidad4.Size = new System.Drawing.Size(298, 49);
            this.btnUnidad4.TabIndex = 3;
            this.btnUnidad4.Text = "Unidad 4";
            this.btnUnidad4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el tema al cual ingresar:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(145, 302);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(298, 49);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 360);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnidad4);
            this.Controls.Add(this.btnUnidad3);
            this.Controls.Add(this.btnUnidad2);
            this.Controls.Add(this.btnUnidad1);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnidad1;
        private System.Windows.Forms.Button btnUnidad2;
        private System.Windows.Forms.Button btnUnidad3;
        private System.Windows.Forms.Button btnUnidad4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

