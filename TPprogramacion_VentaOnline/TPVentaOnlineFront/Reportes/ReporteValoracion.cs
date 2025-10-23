using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPprogramacion_VentaOnline.Data;
using TPprogramacion_VentaOnline.Modelo;


namespace TPVentaOnlineFront.Reportes
{
    public partial class ReporteValoracion : Form
    {
        public ReporteValoracion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM aBM = new ABM();
            aBM.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContex())
            {
                int contador1 = 0;
                int contador2 = 0;
                int contador3 = 0;
                int contador4 = 0;
                int contador5 = 0;
                foreach (var Puntuacion in context.Puntuaciones.ToList())
                {

                    if (Puntuacion.Valoracion == 1)
                    {
                        contador1++;
                        listBox1.Items.Add($"La cantidad de 1 Estrella es : {contador1} ");
                    }
                    else if (Puntuacion.Valoracion == 2)
                    {
                        contador2++;
                        listBox1.Items.Add($"La cantidad de 2 Estrella es : {contador2} ");
                    }
                    else if (Puntuacion.Valoracion == 3)
                    {
                        contador3++;
                        listBox1.Items.Add($"La cantidad de 3 Estrella es: {contador3} ");
                    }
                    else if (Puntuacion.Valoracion == 4)
                    {
                        contador4++;
                        listBox1.Items.Add($"La cantidad de 4 Estrella es: {contador4} ");
                    }
                    else if (Puntuacion.Valoracion == 5)
                    {
                        contador5++;
                        listBox1.Items.Add($"La cantidad de 5 Estrella es: {contador5} ");

                    }
                }
            
            }
        }
    }
}
