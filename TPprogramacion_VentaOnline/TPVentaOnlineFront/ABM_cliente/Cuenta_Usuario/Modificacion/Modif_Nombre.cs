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

namespace TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario
{
    public partial class Modif_Nombre : Form
    {
        public Modif_Nombre()
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
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContex())
            {
                foreach (var cliente in context.Clientes)
                {
                    if (cliente.Nombre == textBox1.Text)
                    {
                        if (textBox2.Text == textBox3.Text)
                        {
                            cliente.Nombre = textBox2.Text;
                            context.SaveChanges();
                            MessageBox.Show("Nombre modificado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("El nuevo nombre y la confirmación no coinciden. Por favor, inténtelo de nuevo.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre actual es incorrecto. Por favor, inténtelo de nuevo.");
                        return;
                    }
                }
            }
        }
    }

}
