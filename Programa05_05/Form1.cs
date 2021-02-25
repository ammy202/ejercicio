using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar elementos de manera programática
            listbFrutas.Items.Add("Cambur");
            listbFrutas.Items.Add("Durazno");
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            listbFrutas.Items.Add(txtFrutas.Text);

            //Para que el texBox quede en blanco después de agrepar elementos
            txtFrutas.Text = string.Empty;
            //También podemos colocar: txtFrutas.Text = "";

        }

        private void ListbFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listbFrutas.SelectedIndex!=-1)
                lblFrutas.Text = (String)listbFrutas.Items[listbFrutas.SelectedIndex];

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int indice = listbFrutas.SelectedIndex;

            if (indice != -1)
            {
                listbFrutas.Items.RemoveAt(indice);

                lblFrutas.Text = "";
            }

        }
    }
}
