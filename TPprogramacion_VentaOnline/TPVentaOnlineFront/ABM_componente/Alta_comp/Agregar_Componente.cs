using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPprogramacion_VentaOnline.Modelo;
using TPprogramacion_VentaOnline.Repositories;

namespace TPVentaOnlineFront
{
    public partial class Agregar_Componente : Form
    {
        
        public Agregar_Componente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABM aBM = new ABM();

            aBM.Show();

            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tipo = comboBox1.SelectedItem.ToString();
            string marca = textBox2.Text;
            string modelo = textBox3.Text;
            float precio = float.Parse(textBox4.Text);
            int stock = int.Parse(textBox5.Text);
            Componente Nuevocomponente = new Componente(tipo, marca, modelo, precio, stock);


            RepositoriesComponente.AgregarComponente(Nuevocomponente);

            MessageBox.Show("Componente agregado con exito");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Agregar_Componente_Load(object sender, EventArgs e)
        {

        }
    }
}
