using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04
{
    public partial class Form2 : Form
    {
        string _mensaje;
        string _contenido;
        bool _salir;

        public Form2()
        {
            InitializeComponent();
            _salir = false;
        }

        public string Mensaje
        {
            get
            {
                return _mensaje;
            }
        }

        public string Contenido
        {
            get
            {
                return _contenido;
            }
        }

        public bool Salir
        {
            get
            {
                return _salir;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            _mensaje = txtMensaje.Text;
            _contenido = txtContenido.Text;
            _salir = true; 
            this.Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            _mensaje = txtMensaje.Text;
            _contenido = txtContenido.Text;
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
