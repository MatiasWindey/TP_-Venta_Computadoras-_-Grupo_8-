using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPVentaOnlineFront.ABM_cliente.Alta_Usuario;

namespace TPVentaOnlineFront
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM aBM = new ABM();

            aBM.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioSesion_usu InicioUsu = new InicioSesion_usu();

            InicioUsu.Show();

            this.Hide();
        }
    }
}


