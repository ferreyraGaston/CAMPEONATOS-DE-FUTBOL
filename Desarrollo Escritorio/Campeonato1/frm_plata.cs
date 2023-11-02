using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_plata : Form
    {
        public List<Equipos> objCargaE = new List<Equipos>();
        public ClaseEquipos objCargaEquipo = new ClaseEquipos();
        public Partidos objpartido = new Partidos();
        public ClasePartidos objCargapartido = new ClasePartidos();
        public frm_plata()
        {
            InitializeComponent();
        }


        private void btn_cargar_Click(object sender, EventArgs e)
        {
            ClaseEquipos claseEquipos = new ClaseEquipos();
            List<string> nombresEquipos = claseEquipos.ListadoEquiposPlayoff();

            if (nombresEquipos != null && nombresEquipos.Count >= 8)
            {
                txt_eq1.Text = nombresEquipos[8];
                txt_eq2.Text = nombresEquipos[9];
                txt_eq3.Text = nombresEquipos[10];
                txt_eq4.Text = nombresEquipos[11];
                txt_eq5.Text = nombresEquipos[12];
                txt_eq6.Text = nombresEquipos[13];
                txt_eq7.Text = nombresEquipos[14];
                txt_eq8.Text = nombresEquipos[15];
            }
            else
            {
                MessageBox.Show("No se encontraron suficientes equipos o hubo un error al cargar los datos.");
            }
        }



        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
