using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programa05_08
{
    public partial class Form1 : Form
    {

        ListViewGroup frutas = new ListViewGroup("Frutas", HorizontalAlignment.Left);
        ListViewGroup carnes = new ListViewGroup("Carnes", HorizontalAlignment.Left);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Creamos un obkjeto de tipo Imagelist
            ImageList misImagenes = new ImageList();
            misImagenes.ImageSize = new Size(100, 100);

            //Obtenemos el listado de las imagenes
            string[] archivos = Directory.GetFiles("\\Users\\safen\\OneDrive\\Imágenes\\imagenes para practica");

            //Cargamos los archivos
            try
            {
                foreach (string archivo in archivos)
                    misImagenes.Images.Add(Image.FromFile(archivo));
            }
            catch
            {
                MessageBox.Show("Algo salió mal al cargar");
            }

            //Asignamos el Imagelist al ListView
            listvAlimentos.SmallImageList = misImagenes;
            
            //Creamos una instancia de tipo ListViewItem para cada grupo
            //Se indica qué elemento va a tener qué imagen por medio de un índice
            listvAlimentos.Items.Add(new ListViewItem("Manzana",0, frutas));
            listvAlimentos.Items.Add(new ListViewItem("Patilla",1, frutas));
            listvAlimentos.Items.Add(new ListViewItem("Melón",2, frutas));
            listvAlimentos.Items.Add(new ListViewItem("Cambur",3, frutas));
            listvAlimentos.Items.Add(new ListViewItem("Mango",4, frutas));

            //Otra forma de crear la instancia (tradicional)
            ListViewItem miElemento = new ListViewItem("Pollo", carnes);
            listvAlimentos.Items.Add(miElemento);
            
            //Continuaremos con el primer modo de crear la instancia que se mostró
            listvAlimentos.Items.Add(new ListViewItem("Res", carnes));
            listvAlimentos.Items.Add(new ListViewItem("Pescado", carnes));
            listvAlimentos.Items.Add(new ListViewItem("Cerdo", carnes));

            //Adicionamos los grupos al ListView
            listvAlimentos.Groups.Add(frutas);
            listvAlimentos.Groups.Add(carnes);


           

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (rbFrutas.Checked == true)
            {
                listvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, frutas));
            }

            if (rbCarnes.Checked == true)
            {
                listvAlimentos.Items.Add(new ListViewItem(txtElemento.Text, carnes));
            }

            txtElemento.Text = "";

        }

        private void ListvAlimentos_MouseClick(object sender, MouseEventArgs e)
        {
            lblSeleccionado.Text = listvAlimentos.SelectedItems[0].SubItems[0].Text;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            listvAlimentos.Items.Clear();
            lblSeleccionado.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listvAlimentos.SelectedItems[0].SubItems[0].Text = txtElemento.Text;
            listvAlimentos.SelectedItems[0].ImageIndex = Convert.ToInt32( txtImagen.Text);
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            listvAlimentos.Items.RemoveAt(listvAlimentos.SelectedIndices[0]);
        }
    }
}
