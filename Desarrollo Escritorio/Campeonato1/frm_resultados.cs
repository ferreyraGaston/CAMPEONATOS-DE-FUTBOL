using CapaDatos;
using Entidades;
using System;
using System.Data;
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
            dgv_datos1.Columns.Clear();
            dgv_datos1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dgv_datos1.DataSource = dt;
            dgv_datos1.Columns[0].Width = 70;
            dgv_datos1.Columns[1].Width = 140;
            dgv_datos1.Columns[2].Width = 40;
            dgv_datos1.Columns[3].Width = 140;
            dgv_datos1.Columns[4].Width = 40;
            dgv_datos1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


 
        private void btn_ver_Click(object sender, EventArgs e)
        {
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();
            dgv_datos1.Columns.Clear();
            dgv_datos1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dgv_datos1.DataSource = dt;
            dgv_datos1.Columns[0].Width = 70;
            dgv_datos1.Columns[1].Width = 140;
            dgv_datos1.Columns[2].Width = 40;
            dgv_datos1.Columns[3].Width = 140;
            dgv_datos1.Columns[4].Width = 40;
            dgv_datos1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgv_datos1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            posicion = dgv_datos1.CurrentRow.Index;
            usuarioObj.Equipo1 = dgv_datos1[1, posicion].Value.ToString();
            usuarioObj.Equipo2 = dgv_datos1[3, posicion].Value.ToString();

            //MessageBox.Show("Equipo 1: " + usuarioObj.Equipo1, "Alerta");
            //MessageBox.Show("Equipo 2: " + usuarioObj.Equipo2, "Alerta");

            Partidos IdPartidos = new Partidos();
            IdPartidos.pID_partido = int.Parse(dgv_datos1[0, posicion].Value.ToString());

            frm_carga_resultados form3 = new frm_carga_resultados();

            // Mostrar el formulario
            form3.Show();
        }

        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
    }
}


