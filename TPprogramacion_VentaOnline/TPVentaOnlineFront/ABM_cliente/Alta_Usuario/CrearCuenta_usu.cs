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
using TPprogramacion_VentaOnline.Repositories;

namespace TPVentaOnlineFront.ABM_cliente.Alta_Usuario
{
    public partial class CrearCuenta_usu : Form
    {
        public CrearCuenta_usu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            string correo = textBox1.Text;
            string contrasenia = textBox3.Text;
            string confirmarcontrasenia = textBox4.Text;
            if (contrasenia == confirmarcontrasenia)
            {
                MessageBox.Show("Cuenta Creada con Exito");


                Cliente cliente = new Cliente(nombre, correo, contrasenia);
                RepositoriesCliente.AgregarCliente(cliente);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicioSesion_usu InicioSesion = new InicioSesion_usu();

            InicioSesion.Show();

            this.Hide();
        }

        private void CrearCuenta_usu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio menu = new Inicio();

            menu.Show();

            this.Hide();
        }
    
    }
}
