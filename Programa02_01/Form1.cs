using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola a todos");
            //MessageBox.Show("Hola a todos", "Mensaje");
            DialogResult r = MessageBox.Show("Probando botones", "Botones", 
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);

            if (r == DialogResult.Ignore)
                lblMensaje.Text = "Omitir";

            if (r == DialogResult.Retry)
                lblMensaje.Text = "Reintentar";

            if (r == DialogResult.Abort)
                lblMensaje.Text = "Anular";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

        }
    }
}
