using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPprogramacion_VentaOnline.Repositories;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Data;



namespace TPVentaOnlineFront
{

    public partial class Baja_Componente : Form
    {

        public Baja_Componente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Baja_Componente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ABM aBM = new ABM();

            aBM.Show();

            this.Hide();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContex())
            {
                foreach (Componente componente in context.Componentes)
                {
                    listBox1.Items.Add($"ID: {componente.Id} - {componente.Marca} {componente.Modelo}");
                }

            }

        }
        private void listBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            RepositoriesComponente.EliminarComponente(Id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(textBox1.Text);
        }


    } 
}
