using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa04_01
{
    public partial class Form1 : Form
    {
        int conteo;

        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private void TmrPrueba_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblValor.Text = conteo.ToString();

            if(pgbTrabajo.Value<100)
                pgbTrabajo.Value++;
            if (pgbTrabajo.Value == 100)
                tmrPrueba.Enabled = false;
                       
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = true;
            pgbTrabajo.Value = 0;

            //Tambien se puede iniciar el timer con el siguiente método:
            //tmrPrueba.Start();
            //Lo que hace es colocar Enabled en true;

        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            tmrPrueba.Enabled = false;
            trbIntervalo.Value = trbIntervalo.Minimum;
            //lblTvalor.Text = trbIntervalo.Value.ToString();
            tmrPrueba.Interval = trbIntervalo.Value;

            //Tambien se puede detener el timer con el siguiente método:
            //tmrPrueba.Stop();
            //Lo que hace es colocar Enabled en false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPrueba.Enabled = false;
        }

        private void TrbIntervalo_Scroll(object sender, EventArgs e)
        {
            //lblTvalor.Text = trbIntervalo.Value.ToString();
            tmrPrueba.Interval = trbIntervalo.Value;
        }

        private void PgbTrabajo_Click(object sender, EventArgs e)
        {

        }

        private void LblTvalor_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTvalor.Text = "";
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < 100000; n++)
                // aquí algún proceso

                if (n % 1000 == 0)
                    pgbTrabajo.PerformStep();

        }
    }
}
