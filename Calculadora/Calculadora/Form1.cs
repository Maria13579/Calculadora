using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        static Operaciones op = new Operaciones();
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSuma_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Suma(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdResta_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Resta(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdMulti_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Mult(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }

        private void cmdDiv_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.Div(double.Parse(txtv1.Text), double.Parse(txtv2.Text)).ToString();
        }
    }
  
}
