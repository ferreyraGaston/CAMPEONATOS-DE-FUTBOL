using CapaDatos;
using Entidades;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_resultados : Form
    {
        private resultados usuarioObj = new resultados();
        public Fechas objFechas = new Fechas();
        public ClaseFecha objClaseFecha = new ClaseFecha();
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public int posicion = 0;
        public frm_resultados()
        {
            InitializeComponent();
            CargarCmbE();
            //CargarDatadrid();

        }
        private void CargarCmbE()
        {
            cmb_fechas.DataSource = objClaseFecha.listadoFechas();
            cmb_fechas.DisplayMember = "pNum_fecha";
            cmb_fechas.ValueMember = "pID_fecha";
            cmb_fechas.SelectedIndex = -1;

        }
        private void CargarDatadrid()
        {
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();

            // Asignar el resultado directamente al origen de datos del DataGridView
            dataGridView1.DataSource = objCargapartido.listadoPartidos(dato, busqueda);

            // Configurar las columnas y la alineación
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();

            // Configurar el origen de datos del DataGridView y las columnas
            dataGridView1.DataSource = objCargapartido.listadoPartidos(dato, busqueda);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 40;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[5].Width = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PicSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            usuarioObj.Equipo1 = dataGridView1[2, posicion].Value.ToString();
            usuarioObj.Equipo2 = dataGridView1[4, posicion].Value.ToString();

            //MessageBox.Show("Equipo 1: " + usuarioObj.Equipo1, "Alerta");
            //MessageBox.Show("Equipo 2: " + usuarioObj.Equipo2, "Alerta");

            Partidos IdPartidos = new Partidos();
            IdPartidos.pID_partido = int.Parse(dataGridView1[0, posicion].Value.ToString());

            frm_carga_resultados form3 = new frm_carga_resultados();

            // Mostrar el formulario
            form3.Show();
        }
    }
}
