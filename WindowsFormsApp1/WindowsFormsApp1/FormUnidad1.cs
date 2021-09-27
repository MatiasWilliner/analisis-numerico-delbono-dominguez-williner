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
            comboBox1.Items.Add("Newton Raphson");
            comboBox1.Items.Add("Secante");
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
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Bisección":
                    Function f = new Function("f(x)" + "=" + txtFuncion.Text);
                    double xi = double.Parse(txtPrimerValor.Text);
                    double xd = double.Parse(txtSegundoValor.Text);
                    int numeroIteraciones = int.Parse(txtIteraciones.Text);
                    double tolerancia = double.Parse(txtTolerancia.Text);
                    Respuesta resultado = principal.CalcularBiseccion(f, xi, xd, numeroIteraciones, tolerancia);
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
                    break;

                case "Regla falsa":
                    //abs(x^2-4)+2*x
                    //ln(x)+(1/x)-3
                    f = new Function("f(x)" + "=" + txtFuncion.Text);
                    xi = double.Parse(txtPrimerValor.Text);
                    xd = double.Parse(txtSegundoValor.Text);
                    numeroIteraciones = int.Parse(txtIteraciones.Text);
                    tolerancia = double.Parse(txtTolerancia.Text);
                    resultado = principal.CalcularReglaFalsa(f, xi, xd, numeroIteraciones, tolerancia);
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
                    break;

                case "Newton Raphson":
                    f = new Function("f(x)" + "=" + txtFuncion.Text);
                    xi = double.Parse(txtPrimerValor.Text);
                    numeroIteraciones = int.Parse(txtIteraciones.Text);
                    tolerancia = double.Parse(txtTolerancia.Text);
                    resultado = principal.CalcularNewtonRaphson(f, xi, numeroIteraciones, tolerancia);
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
                    break;

                case "Secante":
                    f = new Function("f(x)" + "=" + txtFuncion.Text);
                    //xi = double.Parse(txtPrimerValor.Text);
                    //xd = double.Parse(txtSegundoValor.Text);
                    xd = double.Parse(txtPrimerValor.Text);
                    xi = double.Parse(txtSegundoValor.Text);
                    numeroIteraciones = int.Parse(txtIteraciones.Text);
                    tolerancia = double.Parse(txtTolerancia.Text);
                    resultado = principal.CalcularSecante(f, xi, xd, numeroIteraciones, tolerancia);
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
                    break;

                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFuncion.Enabled = true;
            txtPrimerValor.Enabled = true;
            txtSegundoValor.Enabled = true;
            txtIteraciones.Enabled = true;
            txtTolerancia.Enabled = true;
            if (comboBox1.Text == "Newton Raphson")
            {
                txtSegundoValor.Visible = false;
                lblSegundoValor.Visible = false;
            }
            else
            {
                txtSegundoValor.Visible = true;
                lblSegundoValor.Visible = true;
            }
        }

        
    }
}
