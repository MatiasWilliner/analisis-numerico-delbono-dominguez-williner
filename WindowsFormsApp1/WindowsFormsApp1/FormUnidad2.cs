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
    public partial class FormUnidad2 : Form
    {
        Principal principal = new Principal();
        public FormUnidad2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Gauss Jordan");
            comboBox1.Items.Add("Gauss Seidel");
            btnCalcular.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            btnCalcular.Enabled = false;
            btnGenerar.Enabled = true;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Gauss Jordan":
                    int tamaño = int.Parse(txtDimension.Text);
                    double[,] arreglo=new double[tamaño,tamaño+1];
                    for (int i = 0; i < tamaño; i++)
                    {
                        for (int j = 0; j < tamaño+1; j++)
                        {
                            Control txtObtenido = panel1.Controls.Find("txt" +i.ToString()+j.ToString(),true).First();
                            arreglo[i, j] = double.Parse((txtObtenido as TextBox).Text);
                        }
                    }
                    principal.CaclularGaussJordan(arreglo);
                    break;
                case "Gauss Seidel":
                    break;
                default:
                    break;
                
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            btnGenerar.Enabled = false;

            try
            {
                int fila = int.Parse(txtDimension.Text);
                int columna = int.Parse(txtDimension.Text)+1;
                int puntoX = 30;
                int puntoY = 40;
                panel1.Controls.Clear();
                for (int i = 0; i < fila; i++)
                {
                    puntoX = 30;
                    TextBox txtCreado = new TextBox();
                    //txtCreado.Text = (i + 1).ToString();
                    txtCreado.Location = new Point(puntoX, puntoY);
                    panel1.Controls.Add(txtCreado);
                    panel1.Show();
                    for (int j = 0; j < columna; j++)
                    {
                        txtCreado = new TextBox();
                        txtCreado.Text = (j + 1).ToString();
                        txtCreado.Name = $"txt{i}{j}";
                        txtCreado.Location = new Point(puntoX, puntoY);
                        panel1.Controls.Add(txtCreado);
                        panel1.Show();
                        puntoX += 100;
                    }
                    puntoY += 20;
                }
            }
            catch(Exception)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }
    }
}
