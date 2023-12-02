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
            int busqueda = 1;  // Cambia esto a tu valor de búsqueda
            DataTable tablaPosiciones = objTabla.listadoPosiciones(busqueda); // Llama a listadoPosiciones desde el objeto objTabla
            ConfigurarColumnas(); // Configura las columnas primero
            MostrarTablaEnDGV(tablaPosiciones);
        }

        private void ConfigurarColumnas()
        {
            dgv_posicion.Columns.Clear();

            // Define la estructura de datos para las columnas y sus anchuras
            var columnasYAnchos = new Dictionary<string, int>
            {
                { "nombre", 140 },
                { "P_jug", 40 },
                { "P_gan", 40 },
                { "P_emp", 40 },
                { "P_per", 40 },
                { "G_fav", 40 },
                { "G_con", 40 },
                { "Dif_G", 40 },
                { "puntaje", 60 }
            };

            // Agregar las columnas al DataGridView y configurar sus anchuras
            foreach (var columna in columnasYAnchos)
            {
                dgv_posicion.Columns.Add(columna.Key, columna.Key); // Utiliza la cadena como nombre de columna
                dgv_posicion.Columns[columna.Key].Width = columna.Value;
                dgv_posicion.Columns[columna.Key].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void MostrarTablaEnDGV(DataTable tabla)
        {
            // Asegúrate de que el DataGridView está limpio antes de cargar nuevos datos
            dgv_posicion.Rows.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                dgv_posicion.Rows.Add(
                    fila["nombre"],  // Cambia esto para que coincida con las columnas de tu tabla
                    fila["P_jug"],
                    fila["P_gan"],
                    fila["P_emp"],
                    fila["P_per"],
                    fila["G_fav"],
                    fila["G_con"],
                    fila["Dif_G"],
                    fila["puntaje"]
                );
            }
        }
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
    }
}
