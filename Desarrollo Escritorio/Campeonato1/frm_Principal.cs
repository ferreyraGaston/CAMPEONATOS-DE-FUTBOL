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
    public partial class frm_Principal : Form
    {

        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            // Cierra toda la aplicación
            Application.Exit();
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

        private void cargaDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_resultados form_result = new frm_resultados();
            form_result.ShowDialog();
        }

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Realiza cualquier tarea necesaria antes de cerrar el formulario

                // Cierra toda la aplicación
                Application.Exit();
            }
        }
    }
}
