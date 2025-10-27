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
using TPVentaOnlineFront.ABM_cliente.Modificacion_Usuario;

namespace TPVentaOnlineFront.Reportes
{
    public partial class ReporteComponentes : Form
    {
        public ReporteComponentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM Abm = new ABM();
            Abm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new AplicationDbContex())
            {
                int cantidadComponentes = 0;
                if (context.Componentes.Count() == 0)
                {
                    MessageBox.Show("No hay componentes registrados.");
                    return;
                }
                foreach (var componente in context.Componentes.ToList())
                {
                    cantidadComponentes += componente.Stock;
                }
                listBox1.Items.Add($" La cantidad de componentes disponible es : {cantidadComponentes}");

            }
        }
    }
}
