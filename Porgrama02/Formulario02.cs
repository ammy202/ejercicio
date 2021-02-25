using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porgrama02
{
    public partial class Formulario02 : Form
    {
        public Formulario02()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblMensaje_Click(object sender, EventArgs e)
        {
           

        }

        private void BtnSaludo_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = txtNombre.Text + " es el nombre ¡¡Hola!!";
        }

        private void Formulario02_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
        }
    }
}
