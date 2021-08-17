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
    public partial class Form2 : Form
    {
        Principal principal = new Principal();
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bisección");
            comboBox1.Items.Add("regla falsa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Bisección")
            {
                
                Function funcion = new Function($"funcion(x)={textBox1.Text}");
                int xi = int.Parse(textBox2.Text);
                int xd = int.Parse(textBox3.Text);
                int numeroIteraciones = int.Parse(textBox4.Text);
                double tolerancia = double.Parse(textBox5.Text);
                Respuesta resultado=principal.RealizarCalculo(funcion,xi,xd,numeroIteraciones,tolerancia);
                label15.Text = resultado.Converge;
                label15.Text= resultado.Converge;
                label11.Text = resultado.Comentario;
                label14.Text = resultado.Raiz;
                label13.Text = resultado.Iteraciones;
                label12.Text = resultado.Error;
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
