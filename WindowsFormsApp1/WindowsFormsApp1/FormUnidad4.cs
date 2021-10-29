using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using Logica;

namespace WindowsFormsApp1
{
    public partial class FormUnidad4 : Form
    {
        Principal principal = new Principal();
        public FormUnidad4()
        {
            InitializeComponent();
            comboBox1.Items.Add("Trapecio");
            comboBox1.Items.Add("Trapecio múltiples");
            comboBox1.Items.Add("Simpson 1/3");
            comboBox1.Items.Add("Simpson 1/3 múltiples");
            txtCantidad.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double xi = double.Parse(txtXi.Text);
            double xf = double.Parse(txtXf.Text);
            Function f = new Function("f(x)" + "=" + txtFuncion.Text);
            switch (comboBox1.Text)
            {
                case "Trapecio":
                    double area=principal.CalcularMetodoTrapecio(xi,xf,f);
                    txtArea.Text=area.ToString();
                    break;
                case "Trapecio múltiples":
                    int cantidad=int.Parse(txtCantidad.Text);
                    area = principal.CalcularMetodoTrapeciosMultiples(xi,xf,f,cantidad);
                    txtArea.Text = area.ToString();
                    break;
                case "Simpson 1/3":
                    area = principal.CalcularSimpson(xi, xf, f);
                    txtArea.Text = area.ToString();
                    break;
                case "Simpson 1/3 múltiples":
                    cantidad = int.Parse(txtCantidad.Text);
                    area = principal.CalcularSimpsonMultiple(xi, xf, f, cantidad);
                    txtArea.Text = area.ToString();
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Trapecio" || comboBox1.Text== "Simpson 1/3")
            {
                txtCantidad.Enabled = false;
            }
            else
            {
                txtCantidad.Enabled = true;
            }
        }
    }
}
