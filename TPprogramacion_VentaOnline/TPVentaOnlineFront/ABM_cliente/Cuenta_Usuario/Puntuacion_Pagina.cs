using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Data;
using TPprogramacion_VentaOnline.Repositories;
using TPVentaOnlineFront.Reportes;

namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    public partial class Puntuacion_Pagina : Form
    {

        public Puntuacion_Pagina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 0;
            if (radioButton1.Checked)
            {
                valor = 1;
            }
            else if (radioButton2.Checked)
            {
                valor = 2;
            }
            else if (radioButton3.Checked)
            {
                valor = 3;
            }
            else if (radioButton4.Checked)
            {
                valor = 4;
            }
            else if (radioButton5.Checked)
            {
                valor = 5;
            }

            if (valor == 0)
            {
                MessageBox.Show("Por favor, seleccione una puntuación antes de enviar.");
                return;
            }
            MessageBox.Show("Gracias por su puntuación!");

            Puntuacion puntuacion = new Puntuacion(valor);
            RepositoriesPuntuacion.AgregarPuntuacion(puntuacion);
        }

        private void Puntuacion_Pagina_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cuenta_usu cuenta_Usu = new Cuenta_usu();
            cuenta_Usu.Show();
            this.Hide();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
