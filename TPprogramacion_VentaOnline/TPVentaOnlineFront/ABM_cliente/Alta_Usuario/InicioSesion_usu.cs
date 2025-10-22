using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario;
using TPprogramacion_VentaOnline.Modelo;

namespace TPVentaOnlineFront.ABM_cliente.Alta_Usuario
{
    
    public partial class InicioSesion_usu : Form
    {
        List<Cliente> LCliente = new List<Cliente>();
        public InicioSesion_usu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string contrasenia = textBox2.Text;
            foreach (Cliente cliente in LCliente)
            {
                if (cliente.Nombre == nombre && cliente.Contrasenia == contrasenia)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Nombre o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                    return;
                }
            }
            Cuenta_usu Perfil = new Cuenta_usu();

            Perfil.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCuenta_usu CrearCuenta = new CrearCuenta_usu();

            CrearCuenta.Show();

            this.Hide();
        }
    }
}
