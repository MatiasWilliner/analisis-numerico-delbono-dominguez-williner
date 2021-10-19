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
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int conteo = dataGridView1.RowCount-1;
            double[,] puntos=new double[conteo,2];
            for (int i = 0; i < conteo; i++)
            {
                puntos[0,i]=int.Parse(dataGridView1[0,i].Value.ToString());
                puntos[1,i]=int.Parse(dataGridView1[1,i].Value.ToString());
            }
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Regresión Líneal":
                    int grado = 1;
                    principal.CalcularRegresionLineal(puntos,conteo,grado);
                    break;
                case "Regresión polinomial":
                    break;
                default:
                    break;
            }
        }
    }
}
