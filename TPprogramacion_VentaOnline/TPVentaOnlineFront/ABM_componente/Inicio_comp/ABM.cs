using TPVentaOnlineFront.Modificacion;
using TPVentaOnlineFront.Reportes;

namespace TPVentaOnlineFront
{
    public partial class ABM : Form
    {
        public ABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Agregar_Componente agregar_Componente = new Agregar_Componente();

            agregar_Componente.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificacion_Componente modificacion_Componente = new Modificacion_Componente();

            modificacion_Componente.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baja_Componente baja_Componente = new Baja_Componente();

            baja_Componente.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio menu = new Inicio();

            menu.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReporteValoracion reporteValoracion = new ReporteValoracion();
            reporteValoracion.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReporteComponentes reporteComponentes = new ReporteComponentes();
            reporteComponentes.Show();
            this.Hide();
        }
    }
}
