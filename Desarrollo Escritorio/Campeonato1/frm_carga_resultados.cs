using CapaDatos;
using Entidades;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.ComponentModel.Design;
using System.Data;
using System.IO.Pipelines;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Campeonato1
{
    public partial class frm_carga_resultados : Form
    {
        public int posicion = 0;
        public string dato = string.Empty;
        public string datoJugador = string.Empty;
        public ClaseEquipos objEquipos = new ClaseEquipos();
        public Equipos objEquipoConsulta = new Equipos();
        private resultados usuarioObj = new resultados();
        public int idPartido = 0;
        Partidos Partidos = new Partidos();
        public frm_carga_resultados()
        {
            InitializeComponent();
            CargarTextbox();
        }
        void CargarTextbox()
        {

            lbEquipo1.Text = usuarioObj.Equipo1;
            lbEquipo2.Text = usuarioObj.Equipo2;

            //MessageBox.Show("Equipo 1: " + usuarioObj.Equipo1, "Alerta");
            //MessageBox.Show("Equipo 2: " + usuarioObj.Equipo2, "Alerta");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string orden = string.Empty;
            string orden2 = string.Empty;
            string ordenPartido = string.Empty;
            string ordenGoles = string.Empty;
            string equipo21 = lbEquipo1.Text;
            string equipo22 = lbEquipo2.Text;

            orden = "SELECT id_equipo FROM equipos WHERE nombre= @equipo21";
            orden2 = "SELECT id_equipo FROM equipos WHERE nombre= @equipo22";


            ClaseConexion connectionString = new ClaseConexion();

            using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
            {
                conexion.Open();

                // Obtener el id del equipo 1 (equipo21)
                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@equipo21", equipo21);
                int idEquipo1 = Convert.ToInt32(cmd.ExecuteScalar());
                Partidos.pEquipo1 = idEquipo1;

                // Obtener el id del equipo 2 (equipo22)
                MySqlCommand cmd2 = new MySqlCommand(orden2, conexion);
                cmd2.Parameters.AddWithValue("@equipo22", equipo22);
                int idEquipo2 = Convert.ToInt32(cmd2.ExecuteScalar());
                Partidos.pEquipo2 = idEquipo2;

                // Obtener el id del partido
                ordenPartido = "SELECT id_partido FROM partidos WHERE id_equipo1=@idEquipo1 and id_equipo2=@idEquipo2";
                MySqlCommand cmdPartido = new MySqlCommand(ordenPartido, conexion);
                cmdPartido.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                cmdPartido.Parameters.AddWithValue("@idEquipo2", idEquipo2);
                idPartido = Convert.ToInt32(cmdPartido.ExecuteScalar());
                Partidos.pID_partido = idPartido;

                //MessageBox.Show("partido ID: " + idPartido, "Alerta");

                // Obtener los valores de equip1 y equip2
                int equip1 = int.Parse(txtEquipo1.Text);
                int equip2 = int.Parse(txtEquipo2.Text);

                //MessageBox.Show("Goles equip1: " + equip1, "Alerta");
                //MessageBox.Show("Goles equip2: " + equip2, "Alerta");

                // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                string updateGolesQuery = "UPDATE partidos SET goles_equipo1 = @equip1, goles_equipo2 = @equip2 WHERE id_partido = @idPartido";
                MySqlCommand cmdUpdateGoles = new MySqlCommand(updateGolesQuery, conexion);
                cmdUpdateGoles.Parameters.AddWithValue("@equip1", equip1);
                cmdUpdateGoles.Parameters.AddWithValue("@equip2", equip2);
                cmdUpdateGoles.Parameters.AddWithValue("@idPartido", idPartido);
                cmdUpdateGoles.ExecuteNonQuery();

                if (equip1 > equip2)
                {
                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery = "UPDATE posiciones SET P_jug = P_jug + 1, P_gan=P_gan + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con, Puntaje=Puntaje+3 WHERE id_equipo = @idEquipo1";
                    MySqlCommand cmdUpdatePosiciones = new MySqlCommand(updatePosicionesQuery, conexion);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol1", equip1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol2", equip2);
                    cmdUpdatePosiciones.ExecuteNonQuery();

                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery2 = "UPDATE posiciones SET P_jug = P_jug + 1, P_gan=P_gan + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con, Puntaje=Puntaje+3 WHERE id_equipo = @idEquipo2";
                    MySqlCommand cmdUpdatePosiciones2 = new MySqlCommand(updatePosicionesQuery2, conexion);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@idEquipo2", idEquipo2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol1", equip2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol2", equip1);
                    cmdUpdatePosiciones2.ExecuteNonQuery();
                }
                else if (equip1 < equip2)
                {
                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery = "UPDATE posiciones SET P_jug = P_jug + 1, P_per=P_per + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con WHERE id_equipo = @idEquipo1";
                    MySqlCommand cmdUpdatePosiciones = new MySqlCommand(updatePosicionesQuery, conexion);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol1", equip1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol2", equip2);
                    cmdUpdatePosiciones.ExecuteNonQuery();

                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery2 = "UPDATE posiciones SET P_jug = P_jug + 1, P_per=P_per + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con WHERE id_equipo = @idEquipo2";
                    MySqlCommand cmdUpdatePosiciones2 = new MySqlCommand(updatePosicionesQuery2, conexion);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@idEquipo2", idEquipo2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol1", equip2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol2", equip1);
                    cmdUpdatePosiciones2.ExecuteNonQuery();
                }
                else if (equip1 == equip2)
                {
                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery = "UPDATE posiciones SET P_jug = P_jug + 1, P_emp=P_emp + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con, Puntaje=Puntaje+1 WHERE id_equipo = @idEquipo1";
                    MySqlCommand cmdUpdatePosiciones = new MySqlCommand(updatePosicionesQuery, conexion);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@idEquipo1", idEquipo1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol1", equip1);
                    cmdUpdatePosiciones.Parameters.AddWithValue("@gol2", equip2);
                    cmdUpdatePosiciones.ExecuteNonQuery();

                    // Actualizar los campos goles_equipo1 y goles_equipo2 en la tabla partidos
                    string updatePosicionesQuery2 = "UPDATE posiciones SET P_jug = P_jug + 1, P_emp=P_emp + 1, G_fav=G_fav+@gol1, G_con=G_con+@gol2, Dif_G=G_fav-G_con, Puntaje=Puntaje+1 WHERE id_equipo = @idEquipo2";
                    MySqlCommand cmdUpdatePosiciones2 = new MySqlCommand(updatePosicionesQuery2, conexion);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@idEquipo2", idEquipo2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol1", equip2);
                    cmdUpdatePosiciones2.Parameters.AddWithValue("@gol2", equip1);
                    cmdUpdatePosiciones2.ExecuteNonQuery();
                }



                // Limpiar los TextBox y mostrar un mensaje de éxito
                txtEquipo1.Clear();
                txtEquipo2.Clear();
                MessageBox.Show("Actualización exitosa");
                conexion.Close();
            }
        }

        private void btnBuenaFe1_Click(object sender, EventArgs e)
        {
            int busqueda = 5;
            // Configurar el origen de datos del DataGridView
            dgv_jugador.Columns.Clear();
            dgv_jugador.DataSource = objEquipos.listadoEquipos(usuarioObj.Equipo1, busqueda);

            // Configurar las anchuras de las columnas
            dgv_jugador.Columns[0].Width = 125;
            dgv_jugador.Columns[1].Width = 125;
            dgv_jugador.Columns[2].Width = 80;
            dgv_jugador.Columns[3].Width = 60;
        }

        private void btnBuenaFe2_Click(object sender, EventArgs e)
        {
            int busqueda = 5;

            // Configurar el origen de datos del DataGridView
            dgv_jugador.Columns.Clear();
            dgv_jugador.DataSource = objEquipos.listadoEquipos(usuarioObj.Equipo2, busqueda);

            // Configurar las anchuras de las columnas
            dgv_jugador.Columns[0].Width = 125;
            dgv_jugador.Columns[1].Width = 125;
            dgv_jugador.Columns[2].Width = 80;
            dgv_jugador.Columns[3].Width = 60;
        }


        private void dgv_jugador_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Jugadores Jugadores = new Jugadores();
            posicion = dgv_jugador.CurrentRow.Index;

            // variable entero
            Jugadores.pDni = int.Parse(dgv_jugador[2, posicion].Value.ToString());

            // variable String
            NameJugador.Text = dgv_jugador[0, posicion].Value.ToString();
            ApellJugador.Text = dgv_jugador[1, posicion].Value.ToString();
            DniJugador.Text = dgv_jugador[2, posicion].Value.ToString();

        }

        private void btnAmarilla_Click(object sender, EventArgs e)
        {
            ClaseConexion connectionString = new ClaseConexion();

            int dni = int.Parse(DniJugador.Text);

            string orden = "SELECT id_jugador FROM jugadores WHERE dni = @dni";
            string ordenPartido = "SELECT id_fecha FROM partidos WHERE id_partido = @id_partido";

            // Obtener el id del jugador
            int idJugador = 0;
            using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@dni", dni);
                idJugador = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Obtener el id de la fecha del partido (suponiendo que tengas el id del partido en 'idPartido2')
            int idPartido2 = Partidos.pID_partido;
            int idFecha = 0;
            using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
            {
                conexion.Open();
                MySqlCommand cmd2 = new MySqlCommand(ordenPartido, conexion);
                cmd2.Parameters.AddWithValue("@id_partido", idPartido2);
                idFecha = Convert.ToInt32(cmd2.ExecuteScalar());
            }

            if (idJugador > 0 && idFecha > 0)
            {
                // Insertar el gol en la tabla 'goles'
                string insertQuery = "INSERT INTO amarillas (id_jugador, id_fecha) VALUES (@id_jugador, @id_fecha)";
                using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
                {
                    conexion.Open();
                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conexion);
                    cmdInsert.Parameters.AddWithValue("@id_jugador", idJugador);
                    cmdInsert.Parameters.AddWithValue("@id_fecha", idFecha);

                    cmdInsert.ExecuteNonQuery();
                }

                // Limpiar los TextBox y mostrar un mensaje de éxito
                textBoxGol.Clear();
                MessageBox.Show("Actualización exitosa");
            }
            else
            {
                MessageBox.Show("Error: No se pudo obtener el id del jugador o de la fecha del partido.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClaseConexion connectionString = new ClaseConexion();

            int dni = int.Parse(DniJugador.Text);

            string orden = "SELECT id_jugador FROM jugadores WHERE dni = @dni";
            string ordenPartido = "SELECT id_fecha FROM partidos WHERE id_partido = @id_partido";

            // Obtener el id del jugador
            int idJugador = 0;
            using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@dni", dni);
                idJugador = Convert.ToInt32(cmd.ExecuteScalar());
            }

            // Obtener el id de la fecha del partido (suponiendo que tengas el id del partido en 'idPartido2')
            int idPartido2 = Partidos.pID_partido;
            int idFecha = 0;
            using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
            {
                conexion.Open();
                MySqlCommand cmd2 = new MySqlCommand(ordenPartido, conexion);
                cmd2.Parameters.AddWithValue("@id_partido", idPartido2);
                idFecha = Convert.ToInt32(cmd2.ExecuteScalar());
            }

            if (idJugador > 0 && idFecha > 0)
            {
                // Insertar el gol en la tabla 'goles'
                string insertQuery = "INSERT INTO rojas (id_jugador, id_fecha) VALUES (@id_jugador, @id_fecha)";
                using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
                {
                    conexion.Open();
                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conexion);
                    cmdInsert.Parameters.AddWithValue("@id_jugador", idJugador);
                    cmdInsert.Parameters.AddWithValue("@id_fecha", idFecha);
                    //cmdInsert.Parameters.AddWithValue("@id_motivo", id_motivo);
                    cmdInsert.ExecuteNonQuery();
                }

                // Limpiar los TextBox y mostrar un mensaje de éxito
                textBoxGol.Clear();
                MessageBox.Show("Actualización exitosa");
            }
            else
            {
                MessageBox.Show("Error: No se pudo obtener el id del jugador o de la fecha del partido.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 0;
            ClaseConexion connectionString = new ClaseConexion();
            if (int.TryParse(textBoxGol.Text, out value) && value > 0)
            {
                int dni = int.Parse(DniJugador.Text);

                string orden = "SELECT id_jugador FROM jugadores WHERE dni = @dni";
                string ordenPartido = "SELECT id_fecha FROM partidos WHERE id_partido = @id_partido";

                // Obtener el id del jugador
                int idJugador = 0;
                using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
                {
                    conexion.Open();
                    MySqlCommand cmd = new MySqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    idJugador = Convert.ToInt32(cmd.ExecuteScalar());
                }

                // Obtener el id de la fecha del partido (suponiendo que tengas el id del partido en 'idPartido2')
                int idPartido2 = Partidos.pID_partido;
                int idFecha = 0;
                using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
                {
                    conexion.Open();
                    MySqlCommand cmd2 = new MySqlCommand(ordenPartido, conexion);
                    cmd2.Parameters.AddWithValue("@id_partido", idPartido2);
                    idFecha = Convert.ToInt32(cmd2.ExecuteScalar());
                }

                if (idJugador > 0 && idFecha > 0)
                {
                    // Insertar el gol en la tabla 'goles'
                    string insertQuery = "INSERT INTO goles (id_jugador, id_fecha, cantidad) VALUES (@id_jugador, @id_fecha, @cantidad)";
                    using (MySqlConnection conexion = new MySqlConnection(connectionString.cadena))
                    {
                        conexion.Open();
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conexion);
                        cmdInsert.Parameters.AddWithValue("@id_jugador", idJugador);
                        cmdInsert.Parameters.AddWithValue("@id_fecha", idFecha);
                        cmdInsert.Parameters.AddWithValue("@cantidad", value);

                        cmdInsert.ExecuteNonQuery();
                    }

                    // Limpiar los TextBox y mostrar un mensaje de éxito
                    textBoxGol.Clear();
                    MessageBox.Show("Actualización exitosa");
                }
                else
                {
                    MessageBox.Show("Error: No se pudo obtener el id del jugador o de la fecha del partido.");
                }
            }
            else
            {
                MessageBox.Show("Error: Ingrese un valor de gol válido mayor que 0.");
            }
        }

    }
}

