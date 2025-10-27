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
using TPprogramacion_VentaOnline.Data;

namespace TPVentaOnlineFront.ABM_cliente.Alta_Usuario
{

    public partial class InicioSesion_usu : Form
    {
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
            string correo = textBox1.Text;
            string contrasenia = textBox2.Text;
            using (var context = new AplicationDbContex())
            {
                var CuentaInicio = context.Clientes.FirstOrDefault(c => c.Correo == correo);
                {
                    if (CuentaInicio.Correo == correo && CuentaInicio.Contrasenia == contrasenia)
                    { 
                        Cuenta_usu Perfil = new Cuenta_usu();

                        Perfil.CorreoUsuario = correo;

                        Perfil.Show();

                        this.Hide();

                        
                    }
                    else
                    {
                        MessageBox.Show("Nombre o contraseña incorrectos. Por favor, inténtelo de nuevo.");
                        return;

                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearCuenta_usu CrearCuenta = new CrearCuenta_usu();

            CrearCuenta.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio menu = new Inicio();

            menu.Show();

            this.Hide();
        }
    }
}
