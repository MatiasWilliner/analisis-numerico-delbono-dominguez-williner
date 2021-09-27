using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            FormUnidad1 unidad1 = new FormUnidad1();
            unidad1.Show();
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUnidad2_Click(object sender, EventArgs e)
        {
            FormUnidad2 unidad2 = new FormUnidad2();
            unidad2.Show();
            this.Visible = false;
        }
    }
}
