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

namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    public partial class Cuenta_usu : Form
    {
        public string CorreoUsuario { get; set; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Modif_Nombre ModifNombre = new Modif_Nombre();
            ModifNombre.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modif_Contraseña ModifContraseña = new Modif_Contraseña();
            ModifContraseña.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new TPprogramacion_VentaOnline.Data.AplicationDbContex())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.Correo == CorreoUsuario);
                if (cliente != null)
                {
                    listBox1.Items.Add(cliente.Correo);
                    listBox2.Items.Add(cliente.Nombre);
                    listBox3.Items.Add(cliente.Contrasenia);
                }
                
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
