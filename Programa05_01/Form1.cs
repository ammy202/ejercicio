using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_01
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        //Otra forma de agregar ítems al checklist
        private void Form1_Load(object sender, EventArgs e)
        {
            chlbAlimentos.Items.Add("Carne");
            chlbAlimentos.Items.Add("Pescado");

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            chlbAlimentos.Items.Add(txtNuevoAlimento.Text);
            txtNuevoAlimento.Text = "";
        }

        private void ChlbAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chlbAlimentos.SelectedIndex;

            if (indice != -1)
                lblNombre.Text = chlbAlimentos.Items[indice].ToString();

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //Se trabaja directamente sobre la colección de elementos
            //Al usar el método RemoveAt se le indica el índice del elemento dentro del listView
            //Nos interesa eliminar el índice del elemento a eliminar, no el elemento
            chlbAlimentos.Items.RemoveAt(chlbAlimentos.SelectedIndices[0]);
            
           
        }
    }
}
