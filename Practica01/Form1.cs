using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

       
        private void BtnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0.0;
            string cotizacion = "";

            cotizacion = "Cotización de auto para " + txtNombre.Text + "\r\n";


            //Obtener costo inicial
            costo = Convert.ToDouble(txtCosto.Text);

            //Verificar seguros
            if (rbBasico.Checked == true)
            {
                costo += 500.0;
                cotizacion += "Seguro básico (500,00$) \r\n";
            }

            if (rbTerceros.Checked == true)
            {
                costo += 700.0;
                cotizacion += "Seguro a terceros (700,00$) \r\n";
            }

            if (rbTotal.Checked == true)
            {
                costo += 1000.0;
                cotizacion += "Seguro total (1000,00$) \r\n";
            }

            //Verificar equipo
            if (chkAire.Checked == true)
            {
                costo += 800.0;
                cotizacion += "Aire acondiconado (800,00$) \r\n";
            }
            if (chkSonido.Checked == true)
            {
                costo += 900.0;
                cotizacion += "Sistema de sonido (900,00$) \r\n";
            }

            //Mostramos el total
            cotizacion += "El total a pagar es " + costo.ToString();

            txtCotizacion.Text = cotizacion;


        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCosto.Clear();
            txtCotizacion.Clear();
            chkAire.Checked = false;
            chkSonido.Checked = false;

            txtNombre.Focus();
        }
    }
}
