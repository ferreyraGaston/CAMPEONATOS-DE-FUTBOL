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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int equip1 = 0;
            int equip2 = 0;
        
            try
            {
                equip1 = int.Parse(txtEquipo1.Text);
                equip2 = int.Parse(txtEquipo2.Text);
            }
            catch
            {
                MessageBox.Show("Valores vacios");
            }

            if (equip1==0 && equip2==0)
            {
                MessageBox.Show("Valores vacios");
            }
            else {
                string connectionString = "Server=localhost;Port=33065;Database=bdcampeonato;Uid=root;Password=;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command10 = connection.CreateCommand();
                MySqlCommand command11 = connection.CreateCommand();
                MySqlCommand command12 = connection.CreateCommand();
                int golEq1 = 28;
                int golEq2 = 30;

                int sumaEquipo = equip1 - equip2;


                command.CommandText = "UPDATE posiciones SET P_jug = P_jug + 1 WHERE id_equipo = ('" + golEq1 + "')";

                command10.CommandText = "UPDATE posiciones SET P_jug = P_jug + 1 WHERE id_equipo = ('" + golEq2 + "')";

                command11.CommandText = "UPDATE posiciones SET Dif_G = Dif_G + ('" + sumaEquipo + "') WHERE id_equipo = ('" + golEq1 + "')";

                command12.CommandText = "UPDATE posiciones SET Dif_G = Dif_G + ('" + sumaEquipo + "') WHERE id_equipo = ('" + golEq2 + "')";

                connection.Open();
                command.ExecuteNonQuery();
                command10.ExecuteNonQuery();
                command11.ExecuteNonQuery();
                command12.ExecuteNonQuery();
                connection.Close();

           

            

            if (equip1 > equip2)
            {
                MySqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "UPDATE posiciones SET P_gan = P_gan + 1 WHERE id_equipo = ('" + golEq1 + "')";// euipo 1

                MySqlCommand command3 = connection.CreateCommand();
                command3.CommandText = "UPDATE posiciones SET P_per = P_per + 1 WHERE id_equipo = ('" + golEq2 + "')"; // euipo 2

                MySqlCommand command4 = connection.CreateCommand();
                command4.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip1 + "') WHERE id_equipo = ('" + golEq1 + "')";// Gol a Favor
               
                MySqlCommand command5 = connection.CreateCommand();
                command5.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip2 + "') WHERE id_equipo = ('" + golEq1 + "')"; // Gol en contra

                MySqlCommand command6 = connection.CreateCommand();
                command6.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip2 + "') WHERE id_equipo = ('" + golEq2 + "')";// Gol a Favor

                MySqlCommand command7 = connection.CreateCommand();
                command7.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip1 + "') WHERE id_equipo = ('" + golEq2 + "')"; // Gol en contra

                MySqlCommand command8 = connection.CreateCommand();
                command8.CommandText = "UPDATE posiciones SET Puntaje = Puntaje + 3 WHERE id_equipo = ('" + golEq1 + "')"; // Puntaje Equipo1

                connection.Open();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
                command7.ExecuteNonQuery();
                command8.ExecuteNonQuery();
                connection.Close();
            }
            else if(equip1 < equip2){
                MySqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "UPDATE posiciones SET P_gan = P_gan + 1 WHERE id_equipo = ('" + golEq2 + "')";// euipo 2

                MySqlCommand command3 = connection.CreateCommand();
                command3.CommandText = "UPDATE posiciones SET P_per = P_per + 1 WHERE id_equipo = ('" + golEq1 + "')"; // euipo 1


                MySqlCommand command4 = connection.CreateCommand();
                command4.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip2 + "') WHERE id_equipo = ('" + golEq2 + "')";// Gol a Favor

                MySqlCommand command5 = connection.CreateCommand();
                command5.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip1 + "') WHERE id_equipo = ('" + golEq2 + "')"; // Gol en contra

                MySqlCommand command6 = connection.CreateCommand();
                command6.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip1 + "') WHERE id_equipo = ('" + golEq1 + "')";// Gol a Favor

                MySqlCommand command7 = connection.CreateCommand();
                command7.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip2 + "') WHERE id_equipo = ('" + golEq1 + "')"; // Gol en contra

                MySqlCommand command8 = connection.CreateCommand();
                command8.CommandText = "UPDATE posiciones SET Puntaje = Puntaje + 3 WHERE id_equipo = ('" + golEq2 + "')"; // Puntaje Equipo2

                    connection.Open();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
                command7.ExecuteNonQuery();
                command8.ExecuteNonQuery();
                connection.Close();
            }
            else if (equip1 == equip2)
            {
                MySqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "UPDATE posiciones SET P_emp = P_emp + 1 WHERE id_equipo = ('" + golEq1 + "')"; // euipo 1
              
                MySqlCommand command3 = connection.CreateCommand();
                command3.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip1 + "') WHERE id_equipo = ('" + golEq1 + "')";// Gol a Favor
               

                MySqlCommand command4 = connection.CreateCommand();
                command4.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip2 + "') WHERE id_equipo = ('" + golEq2 + "')"; // Gol en contra

                ///////////////////////////////////////////////////////////////////////

                MySqlCommand command5 = connection.CreateCommand();
                command5.CommandText = "UPDATE posiciones SET P_emp = P_emp + 1 WHERE id_equipo = ('" + golEq2 + "')"; // euipo 2        

                MySqlCommand command6 = connection.CreateCommand();
                command6.CommandText = "UPDATE posiciones SET G_fav = G_fav + ('" + equip2 + "') WHERE id_equipo = ('" + golEq2 + "')";// Gol a Favor
              

                MySqlCommand command7 = connection.CreateCommand();
                command7.CommandText = "UPDATE posiciones SET G_con = G_con + ('" + equip1 + "') WHERE id_equipo = ('" + golEq1 + "')"; // Gol en contra

                MySqlCommand command8 = connection.CreateCommand();
                command8.CommandText = "UPDATE posiciones SET Puntaje = Puntaje + 1 WHERE id_equipo = ('" + golEq1 + "')"; // Puntaje Equipo1

                MySqlCommand command9 = connection.CreateCommand();
                command9.CommandText = "UPDATE posiciones SET Puntaje = Puntaje + 1 WHERE id_equipo = ('" + golEq2 + "')"; // Puntaje Equipo2

                    connection.Open();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                command4.ExecuteNonQuery();
                command5.ExecuteNonQuery();
                command6.ExecuteNonQuery();
                command7.ExecuteNonQuery();
                command8.ExecuteNonQuery();
                command9.ExecuteNonQuery();
                connection.Close();

                    txtEquipo1.Text = "";
                    txtEquipo2.Text = "";
                    txtEquipo1.Focus();
                }
            }
        }
    }
}
