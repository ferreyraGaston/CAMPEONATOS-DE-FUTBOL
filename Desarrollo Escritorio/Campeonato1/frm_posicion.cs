using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDatos;
using System.Runtime.InteropServices;

namespace Campeonato1
{
    public partial class frm_posicion : Form
    {
        public ClasePosiciones objTabla = new ClasePosiciones();
        public frm_posicion()
        {
            InitializeComponent();
            Mostrar();
        }

        private void Mostrar()
        {
            int busqueda = 1;
            dgv_posicion.Columns.Clear();
            dgv_posicion.DataSource = null;
            DataTable dt = new DataTable();
            dt = objTabla.listadoPosiciones("", busqueda);
            dgv_posicion.DataSource = dt;
            dgv_posicion.Columns[0].Width = 140;
            dgv_posicion.Columns[1].Width = 40;
            dgv_posicion.Columns[2].Width = 40;
            dgv_posicion.Columns[3].Width = 40;
            dgv_posicion.Columns[4].Width = 40;
            dgv_posicion.Columns[5].Width = 40;
            dgv_posicion.Columns[6].Width = 40;
            dgv_posicion.Columns[7].Width = 40;
            dgv_posicion.Columns[8].Width = 60;
            dgv_posicion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_posicion_Load(object sender, EventArgs e)
        {

        }

        private void dgv_posicion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
