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
    public partial class Cuenta_usu : Form
    {
        public Cuenta_usu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Puntuacion_Pagina Valoracion = new Puntuacion_Pagina();
            Valoracion.Show();
            this.Hide();

        }

        private void Cuenta_usu_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();

        }
    }
}
