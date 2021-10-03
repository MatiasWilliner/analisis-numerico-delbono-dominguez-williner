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
            comboBox1.Enabled = false;
            txtIteraciones.Enabled = false;
            txtTolerancia.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            btnCalcular.Enabled = false;
            btnGenerar.Enabled = true;
            txtIteraciones.Enabled = false;
            txtTolerancia.Enabled = false;
            comboBox1.Enabled = false;
            string variable = "";
            int contador = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Gauss Jordan":
                    int tamaño = int.Parse(txtDimension.Text);
                    double[,] arreglo=new double[tamaño,tamaño+1];
                    for (int i = 0; i < tamaño; i++)
                    {
                        for (int j = 0; j < tamaño+1; j++)
                        {
                            Control txtObtenido = panel1.Controls.Find("txt"+i.ToString()+j.ToString(),true).First();
                            arreglo[i,j] = double.Parse((txtObtenido as TextBox).Text);
                        }
                    }
                    RespuestaUnidad2 respuesta =principal.CaclularGaussJordan(arreglo,tamaño);
                    foreach (var valor in respuesta.Valores)
                    {
                        contador = contador + 1;
                        variable = variable + $" x{contador}: "+valor+" |";
                    }
                    MessageBox.Show(variable,"Resultados Gauss Jordan", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                case "Gauss Seidel":
                    int iteraciones = int.Parse(txtIteraciones.Text);
                    double tolerancia = double.Parse(txtTolerancia.Text);
                    tamaño = int.Parse(txtDimension.Text);
                    arreglo = new double[tamaño, tamaño + 1];
                    for (int i = 0; i < tamaño; i++)
                    {
                        for (int j = 0; j < tamaño + 1; j++)
                        {
                            Control txtObtenido = panel1.Controls.Find("txt" + i.ToString() + j.ToString(), true).First();
                            arreglo[i, j] = double.Parse((txtObtenido as TextBox).Text);
                        }
                    }
                    respuesta = principal.CalcularGaussSeidel(arreglo,tamaño,iteraciones,tolerancia);
                    foreach (var valor in respuesta.Valores)
                    {
                        contador = contador + 1;
                        variable = variable + $" X{contador}: " + valor+" |";
                    }
                    MessageBox.Show(variable+$" Iteraciones:{respuesta.Iteraciones}","Resultados Gauss Seidel",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                default:
                    break;
                
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            btnGenerar.Enabled = false;
            comboBox1.Enabled = true;
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
                    /*TextBox txtCreado = new TextBox();
                    txtCreado.Location = new Point(puntoX, puntoY);
                    panel1.Controls.Add(txtCreado);
                    panel1.Show();
                    txtCreado.Text = (0).ToString();*/
                    for (int j = 0; j < columna; j++)
                    {
                        TextBox txtCreado = new TextBox();
                        txtCreado.Location = new Point(puntoX, puntoY);
                        panel1.Controls.Add(txtCreado);
                        panel1.Show();
                        puntoX += 100;
                        txtCreado.Text = (0).ToString();
                        //txtCreado.Text = "".ToString();
                        txtCreado.Name = $"txt{i}{j}";  
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString()=="Gauss Seidel")
            {
                txtIteraciones.Enabled = true;
                txtTolerancia.Enabled = true;
            }
            else
            {
                txtIteraciones.Enabled = false;
                txtTolerancia.Enabled = false;
            }
        }
    }
}
