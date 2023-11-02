using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Campeonato1
{
    public partial class frm_Principal2 : Form
    {

        public frm_Principal2()
        {
            InitializeComponent();
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

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargaDeSancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sanciones form3 = new frm_sanciones();

            // Mostrar el formulario
            form3.Show();
        }

        private void cargaDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_resultados form2 = new frm_resultados();

            // Mostrar el formulario
            form2.Show();
        }

        private void tablaDePosicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_posicion form_tabla = new frm_posicion();
            form_tabla.ShowDialog();
        }

        private void copaDeOroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_oro form_oro = new frm_oro();
            form_oro.ShowDialog();
        }

        private void copaDePlataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_plata form_plata = new frm_plata();
            form_plata.ShowDialog();
        }

        private void agregarEquipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_equipos form_equipos = new frm_equipos();
            form_equipos.ShowDialog();
        }

        private void agregarJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_jugadores form_jugadores = new frm_jugadores();
            form_jugadores.ShowDialog();
        }

        private void sorteoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_sorteo form_sorteo = new frm_sorteo();
            form_sorteo.ShowDialog();
        }
    }
}
