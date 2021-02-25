using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03
{
    public partial class Form1 : Form


    {
        Form2 miFotma2 = new Form2("Saludos");

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnvio1_Click(object sender, EventArgs e)
        {
           

            miFotma2.Comentario = txtMensaje.Text;

            //Mostramos la forma
            miFotma2.Show();

         
        }

        private void BtnEnvio2_Click(object sender, EventArgs e)
        {
            miFotma2.Comentario = txtMensaje.Text;
        }
    }
}
