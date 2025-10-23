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
            if (checkBox1.CheckState == CheckState.Checked)
            {
                valor = 1;
            }
            else if (checkBox2.CheckState == CheckState.Checked)
            {
                valor = 2;
            }
            else if (checkBox3.CheckState == CheckState.Checked)
            {
                valor = 3;
            }
            else if (checkBox4.CheckState == CheckState.Checked)
            {
                valor = 4;
            }
            else if (checkBox5.CheckState == CheckState.Checked)
            {
                valor = 5;
            }

            if (valor == 0)
            {
                MessageBox.Show("Por favor, seleccione una puntuación antes de enviar.");
                return;
            }


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
    }
}
