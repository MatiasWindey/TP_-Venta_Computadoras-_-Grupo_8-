using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    public partial class Puntuacion_Pagina : Form
    {
        List<int> Puntuaciones = new List<int>();
        public Puntuacion_Pagina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                Puntuaciones.Add(1);
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                Puntuaciones.Add(2);
            }
            else if (checkBox3.CheckState == CheckState.Checked)
            {
                Puntuaciones.Add(3);
            }
            else if (checkBox4.CheckState == CheckState.Checked)
            {
                Puntuaciones.Add(4);
            }
            else if (checkBox5.CheckState == CheckState.Checked)
            {
                Puntuaciones.Add(5);
            }
            if (Puntuaciones.Count > 0 && Puntuaciones.Count < 2 )
            {
                MessageBox.Show("Gracias por su puntuacion de " + Puntuaciones.Last().ToString() + " estrellas!");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una puntuacion antes de enviar.");
            }
        }
        
    }
}
