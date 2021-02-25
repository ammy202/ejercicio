using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "¡Hola a todos!";
        }

        private void BtnDespedida_Click(object sender, EventArgs e)
        {
            lbMensaje.Text = "¡Adios!";
            this.Text = "¡¡Bye!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMensaje.Text = "";
        }
    }
}
