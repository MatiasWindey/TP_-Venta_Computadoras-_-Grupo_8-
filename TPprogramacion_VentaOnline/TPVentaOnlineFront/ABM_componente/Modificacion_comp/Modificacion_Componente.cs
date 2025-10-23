using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPprogramacion_VentaOnline.Data;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Repositories;

namespace TPVentaOnlineFront.Modificacion
{
    public partial class Modificacion_Componente : Form
    {
        public Modificacion_Componente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ABM aBM = new ABM();

            aBM.Show();

            this.Hide();
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (var context = new AplicationDbContex())
            {
                foreach (Componente componente in context.Componentes)
                {
                    listBox1.Items.Add($"ID:{componente.Id} Tipo :{componente.Tipo} Marca: {componente.Marca} Modelo: {componente.Modelo} Precio: ${componente.Precio} Stock: {componente.Stock}");
                }


            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int id))
            {
                string tipo = textBox1.Text;
                string marca = textBox2.Text;
                string modelo = textBox3.Text;
                float precio = float.Parse(textBox4.Text);
                int stock = int.Parse(textBox5.Text);
                RepositoriesComponente.ModificarComponente(id,tipo,marca,modelo,precio,stock);
                
            }
            MessageBox.Show("Componente Modificado con exito");
        }

        private void Modificacion_Componente_Load(object sender, EventArgs e)
        {

        }
    }
}
