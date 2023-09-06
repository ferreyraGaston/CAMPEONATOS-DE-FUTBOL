using CapaDatos;
using Entidades;
using MySql.Data.MySqlClient;
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
    public partial class frm_carga_resultados : Form
    {
        public int posicion = 0;
        public string dato = string.Empty;
        public string datoJugador = string.Empty;
        public ClaseEquipos objEquipos = new ClaseEquipos();
        public Equipos objEquipoConsulta = new Equipos();
        private MySqlConnection conexion;

        public frm_carga_resultados()
        {
            InitializeComponent();
            CargarTextbox();
        }
        void CargarTextbox()
        {
            resultados usuarioObj2 = new resultados();

            //MessageBox.Show("equipo1 " + usuarioObj2.Equipo2);

            lbEquipo1.Text = usuarioObj2.Equipo1;
            lbEquipo2.Text = usuarioObj2.Equipo2;

        }

        private void btnBuenaFe1_Click(object sender, EventArgs e)
        {
            resultados usuarioObj2 = new resultados();

            int busqueda = 5;
            datoJugador = usuarioObj2.Equipo1;
            dgv_jugador.Columns.Clear();
            dgv_jugador.DataSource = null;
            DataTable dt = new DataTable();
            dt = objEquipos.listadoEquipos(datoJugador, busqueda);
            dgv_jugador.DataSource = dt;
            dgv_jugador.Columns[0].Width = 125;
            dgv_jugador.Columns[1].Width = 125;
            dgv_jugador.Columns[2].Width = 80;
            dgv_jugador.Columns[3].Width = 60;
        }

        private void CerrarConexion()
        {
            throw new NotImplementedException();
        }

        private void AbrirConexion()
        {
            throw new NotImplementedException();
        }

        private void btnBuenaFe2_Click(object sender, EventArgs e)
        {
            resultados usuarioObj2 = new resultados();

            int busqueda = 5;
            datoJugador = usuarioObj2.Equipo2;
            dgv_jugador.Columns.Clear();
            dgv_jugador.DataSource = null;
            DataTable dt = new DataTable();
            dt = objEquipos.listadoEquipos(datoJugador, busqueda);
            dgv_jugador.DataSource = dt;
            dgv_jugador.Columns[0].Width = 125;
            dgv_jugador.Columns[1].Width = 125;
            dgv_jugador.Columns[2].Width = 80;
            dgv_jugador.Columns[3].Width = 60;
        }

        private void dgv_equipo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            resultados usuarioObj = new resultados();
            posicion = dgv_jugador.CurrentRow.Index;
            NameJugador.Text = dgv_jugador[1, posicion].Value.ToString();
            ApellJugador.Text = dgv_jugador[0, posicion].Value.ToString();
            DniJugador.Text = dgv_jugador[2, posicion].Value.ToString();

        }
    }
}
