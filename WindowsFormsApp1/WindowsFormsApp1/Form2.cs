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
        Metodo1 metodo1 = new Metodo1();
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Bisección");
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
                //Expression expresion = new Expression($"funcion({textBox2.Text},{textBox3.Text})", funcion);
                int numeroIteraciones = int.Parse(textBox4.Text);
                double tolerancia = double.Parse(textBox5.Text);
                //bool resultado=metodo1.RealizarCalculo(funcion,xi,xd,numeroIteraciones,tolerancia);
            }
        }
    }
}
