using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa06_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creamos una instancia de la clase Font con las característcas deseadas (tipo, tamaño, etc)
            //Font miFuente = new Font("Arial",20.0f, FontStyle.Bold|FontStyle.Italic);

            //lblMensaje.Font = miFuente;
            
        }

        //Manera más sencilla de hacer lo anterior o que el usuario pueda hacer cambios en 
        //tiempo de ejecución

        private void BtnFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                lblMensaje.Font = fontDialog1.Font;
            }
        }
    }
}
