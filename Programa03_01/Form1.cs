using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo es un ejemplo para menú");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado"; 
        }

        private void SumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a + b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Suma";
            slblResultado.Text = "R=" + r.ToString();

        }

        private void RestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a - b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Resta";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void MultiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a * b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "Multiplicación";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void DivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a / b;

            lblResultado.Text = r.ToString();

            slblValores.Text = "A=" + a.ToString() + " B=" + b.ToString();
            slblOperacion.Text = "División";
            slblResultado.Text = "R=" + r.ToString();
        }

        private void HabilitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Enabled = habilitarToolStripMenuItem.Checked;
            txtB.Enabled = habilitarToolStripMenuItem.Checked;
        }

        private void BorrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtA.Text = "0";

        }

        private void AleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int valor = rnd.Next(0, 99);
            txtA.Text = valor.ToString();

        }
    }
}
