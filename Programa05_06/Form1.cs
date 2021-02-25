using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Image miImagen = Image.FromFile("\\Users\\safen\\OneDrive\\Imágenes\\naka casas\\pequeña2.JPG");
            picImagen.Image = miImagen;

            //Si se quiere cambar el ajuste del tamaño de manera programática
            picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
