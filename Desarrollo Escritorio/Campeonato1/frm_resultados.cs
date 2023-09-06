using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_resultados : Form
    {
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
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

   

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resultados usuarioObj = new resultados();
            posicion = dataGridView1.CurrentRow.Index;
            usuarioObj.Equipo1 = dataGridView1[1, posicion].Value.ToString();
            usuarioObj.Equipo2 = dataGridView1[3, posicion].Value.ToString();


            //MessageBox.Show("equipo1 "+ usuarioObj.Equipo1);

            frm_carga_resultados form3 = new frm_carga_resultados();

            // Mostrar el formulario
            form3.Show();
        }

        

        private void btn_ver_Click(object sender, EventArgs e)
        {
            int busqueda = 1;
            string dato = cmb_fechas.SelectedValue.ToString();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            DataTable dt = new DataTable();
            dt = objCargapartido.listadoPartidos(dato, busqueda);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 40;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

     

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            resultados usuarioObj = new resultados();
            posicion = dataGridView1.CurrentRow.Index;
            usuarioObj.Equipo1 = dataGridView1[1, posicion].Value.ToString();
            usuarioObj.Equipo2 = dataGridView1[3, posicion].Value.ToString();


            //MessageBox.Show("equipo1 "+ usuarioObj.Equipo1);

            frm_carga_resultados form3 = new frm_carga_resultados();

            // Mostrar el formulario
            form3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_resultados_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
