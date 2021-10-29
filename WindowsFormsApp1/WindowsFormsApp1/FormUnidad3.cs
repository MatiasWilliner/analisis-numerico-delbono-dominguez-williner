using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FormUnidad3 : Form
    {
        Principal principal = new Principal();
        public FormUnidad3()
        {
            InitializeComponent();
            comboBox1.Items.Add("Regresión Líneal");
            comboBox1.Items.Add("Regresión polinomial");
            txtRango.Enabled = false;
            txtCondicion.Enabled = false;
            txtFuncion.Enabled = false;
            txtPorcentaje.Enabled = false;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int conteo = dataGridView1.RowCount-1;
            double[,] puntos=new double[conteo,2];
            txtCondicion.Enabled = true;
            txtFuncion.Enabled = true;
            txtPorcentaje.Enabled = true;
            for (int i = 0; i < conteo; i++)
            {
                puntos[i, 0] = double.Parse(dataGridView1[0, i].Value.ToString());
                puntos[i, 1] = double.Parse(dataGridView1[1, i].Value.ToString());
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Regresión Líneal":
                    ResultadoUnidad3 resultado=principal.CalcularRegresionLineal(puntos,conteo);
                    txtCondicion.Text = resultado.Condicion;
                    txtFuncion.Text = resultado.Funcion;
                    txtPorcentaje.Text = resultado.PorcentajeAjuste;
                    break;
                case "Regresión polinomial":
                    int rango = int.Parse(txtRango.Text);
                    resultado = principal.CalcularRegresionPolinomial(puntos, rango, conteo);
                    txtCondicion.Text = resultado.Condicion;
                    txtFuncion.Text = resultado.Funcion;
                    txtPorcentaje.Text = resultado.PorcentajeAjuste;
                    break;
                default:
                    break;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Regresión Líneal")
            {
                txtRango.Enabled = false;
            }
            else
            {
                txtRango.Enabled = true;
                
            }
        }
    }
}
