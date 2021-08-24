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
    public partial class FormUnidad1 : Form
    {
        Principal principal = new Principal();
        public FormUnidad1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bisección");
            comboBox1.Items.Add("Regla falsa");
            txtFuncion.Enabled = false;
            txtPrimerValor.Enabled = false;
            txtSegundoValor.Enabled = false;
            txtIteraciones.Enabled = false;
            txtTolerancia.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            FormInicio menu = new FormInicio();
            menu.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Bisección")
            {
                Function f = new Function("f(x)" + "=" + txtFuncion.Text);
                double xi = double.Parse(txtPrimerValor.Text);
                double xd = double.Parse(txtSegundoValor.Text);
                int numeroIteraciones = int.Parse(txtIteraciones.Text);
                double tolerancia = double.Parse(txtTolerancia.Text);
                Respuesta resultado=principal.RealizarCalculo(f,xi,xd,numeroIteraciones,tolerancia);

                lblResultadoConvergente.Text = resultado.Converge;
                lblResultadoComentario.Text = resultado.Comentario;
                lblResultadoRaiz.Text = resultado.Raiz;
                lblResultadoIteraciones.Text = resultado.Iteraciones;
                lblResultadoError.Text = resultado.Error;

                txtFuncion.Enabled = false;
                txtPrimerValor.Enabled = false;
                txtSegundoValor.Enabled = false;
                txtIteraciones.Enabled = false;
                txtTolerancia.Enabled = false;
                comboBox1.Text = "";
                
            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Regla falsa")
                {
                    //abs(x^2-4)+2*x
                    Function f = new Function("f(x)"+"="+txtFuncion.Text);
                    double xi = double.Parse(txtPrimerValor.Text);
                    double xd = double.Parse(txtSegundoValor.Text);
                    int numeroIteraciones = int.Parse(txtIteraciones.Text);
                    double tolerancia = double.Parse(txtTolerancia.Text);
                    Respuesta resultado = principal.CalcularReglaFalsa(f, xi, xd, numeroIteraciones, tolerancia);

                    lblResultadoConvergente.Text = resultado.Converge;
                    lblResultadoComentario.Text = resultado.Comentario;
                    lblResultadoRaiz.Text = resultado.Raiz;
                    lblResultadoIteraciones.Text = resultado.Iteraciones;
                    lblResultadoError.Text = resultado.Error;

                    txtFuncion.Enabled = false;
                    txtPrimerValor.Enabled = false;
                    txtSegundoValor.Enabled = false;
                    txtIteraciones.Enabled = false;
                    txtTolerancia.Enabled = false;
                    comboBox1.Text = "";
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFuncion.Enabled = true;
            txtPrimerValor.Enabled = true;
            txtSegundoValor.Enabled = true;
            txtIteraciones.Enabled = true;
            txtTolerancia.Enabled = true;
        }
    }
}
