using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            bool error = false;

            foreach(char Caracter in txtDato.Text)
            {
                if (char.IsDigit(Caracter))
                {
                    error = true;
                    break;
                }
            }

            //Verificamos por la condición del error
            if (error)
            {
                errorProvider1.SetError(txtDato, "No se admiten números");

            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void TxtDato_TextChanged(object sender, EventArgs e)
        {
            bool error = false;

            foreach (char Caracter in txtDato.Text)
            {
                if (char.IsDigit(Caracter))
                {
                    error = true;
                    break;
                }
            }

            //Verificamos por la condición del error
            if (error)
            {
                errorProvider1.SetError(txtDato, "No se admiten números");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
