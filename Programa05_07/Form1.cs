using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_07
{
    public partial class Form1 : Form
    {
        int indice;

        public Form1()
        {
            InitializeComponent();
            indice = 0;

        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 8)
                indice = 0;

            lblFoto.ImageIndex = indice;

            picbImagen.Image = imglFotos.Images[indice];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picbImagen.Image = imglFotos.Images[0];
        }
    }
}
