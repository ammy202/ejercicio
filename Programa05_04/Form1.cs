using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dmupFrutas.Items.Add("Melón");
            dmupFrutas.Items.Add("Manzana");

            lblMensaje.Text = "";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dmupFrutas.Items.Add(txtFrutas.Text);

            txtFrutas.Text = "";
        }

        private void DmupFrutas_SelectedItemChanged(object sender, EventArgs e)
        {
            string fruta = (string)dmupFrutas.SelectedItem;

            lblMensaje.Text = string.Format("Tu fruta favorita es {0}, muy sabrosa", fruta);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int indice = dmupFrutas.SelectedIndex;

            dmupFrutas.Items.RemoveAt(indice);
            dmupFrutas.SelectedIndex = 0;
        }
    }
}
