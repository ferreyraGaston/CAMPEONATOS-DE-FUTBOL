using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaDatos;
using Entidades;
using System.Reflection;
using System.Drawing;
using System.Security.Cryptography;

namespace Campeonato1
{
    public partial class frm_sanciones : Form
    {
        public frm_sanciones()
        {
            InitializeComponent();
            Leer();

            // Asociar el evento CellFormatting al DataGridView
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }

        void Leer()
        {
            // Conexión a la base de datos
            ClaseConexion connectionString = new ClaseConexion();
            MySqlConnection connection = new MySqlConnection(connectionString.cadena);

            // Consulta SQL para combinar datos
            string query = "SELECT r.id_roja AS Tarjeta, j.nombre AS Nombre, j.apellido AS Apellido, DATE_FORMAT(dia, '%d/%m/%Y') AS Fecha, 'roja' AS Color " +
                "FROM rojas r " +
                "INNER JOIN jugadores j ON r.id_jugador = j.id_jugador " +
                "INNER JOIN fechas f ON r.id_fecha = f.id_fecha " +
                "UNION " +
                "SELECT a.id_amarilla AS Tarjeta, j.nombre AS Nombre, j.apellido AS Apellido, DATE_FORMAT(dia, '%d/%m/%Y') AS Fecha, 'amarilla' AS Color " +
                "FROM amarillas a " +
                "INNER JOIN fechas f ON a.id_fecha = f.id_fecha " +
                "INNER JOIN jugadores j ON a.id_jugador = j.id_jugador;";


            // Crear un adaptador y un DataSet para cargar los datos
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();

            try
            {
                connection.Open();
                adapter.Fill(dataSet, "Result");

                // Asignar el DataSet al DataGridView
                dataGridView1.DataSource = dataSet.Tables["Result"];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificar si la columna actual es la de "Color"
            if (e.ColumnIndex == dataGridView1.Columns["Color"].Index && e.Value != null)
            {
                // Obtener el valor de la celda en la columna "Color" y convertirlo a cadena
                string tarjeta = e.Value.ToString();

                // Verificar si es una tarjeta roja
                if (tarjeta.Contains("roja"))
                {
                    // Cambiar el color de fondo a rojo
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White; // Cambiar el color del texto a blanco si es necesario
                }
                // Verificar si es una tarjeta amarilla
                else if (tarjeta.Contains("amarilla"))
                {
                    // Cambiar el color de fondo a amarillo
                    e.CellStyle.BackColor = Color.Yellow;
                    e.CellStyle.ForeColor = Color.Black; // Cambiar el color del texto a negro si es necesario
                }
                // Puedes agregar más condiciones para tarjetas amarillas u otros casos aquí
            }

        }
    }
}
