using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa06_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOperaciones_Click(object sender, EventArgs e)
        {

            //Una manera de agregar la fecha:
            //DateTime fecha = new DateTime(2020, 3, 2);
            //lblFecha.Text = fecha.ToString();

            //Si necesitamos colocar la fecha del día:
            //DateTime fecha = DateTime.Today;
            //lblFecha.Text = fecha.ToString();

            //Si necesitamos colocar la fecha de mañana:
            //DateTime fecha = DateTime.Today.AddDays(1);
            //lblFecha.Text = fecha.ToString();

            //Si necesitamos colocar la fecha transcurridos X días (o si es hacia 
            //el pasado se coloca el signo menos (-)antes del número de días):
            //DateTime fecha = DateTime.Today.AddDays(25);
            //lblFecha.Text = fecha.ToString();
            // ó:
            //DateTime fecha = DateTime.Today.AddDays(-45);
            //lblFecha.Text = fecha.ToString();

            //Si necesitamos trabajar con un elemento en particular (año, dia, algùn otro)
            //DateTime fecha = DateTime.Today.AddDays(-45);
            //lblFecha.Text = fecha.Year.ToString();

            //Uso de otros métodos
            //DateTime fecha = DateTime.Today;
            //lblFecha.Text = DateTime.DaysInMonth(2020, 2).ToString();

            //Para cambiar el formato (año, mes, dìa, fecha, hora, minutos) (NOTA: Hay diferentes formatos)
            DateTime fecha = DateTime.Today;
            string formato = "yyy MMM ddd d, HH:MM";


            lblFecha.Text = fecha.ToString(formato);
        }
    }
}
