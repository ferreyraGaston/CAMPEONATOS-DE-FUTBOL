using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Entidades;
using Org.BouncyCastle.Crypto;

namespace CapaDatos
{
    public class ClaseEquipos : ClaseConexion
    {
        public int abmEquipos(string accion, Equipos objEquipo)
        {
            int resultados = -1;
            string orden = string.Empty;

            if (accion == "Agregar")
            {
                orden = "INSERT INTO equipos(nombre, ruta_escudo) VALUES ('" + objEquipo.pNombre.ToUpper() + "', '" + objEquipo.pRuta.Replace("\\", "\\\\") + "');";
            }
            if (accion == "Contar")
            {
                orden = "SELECT COUNT(*) FROM equipos;";
            }

            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            try
            {
                if (accion != "Contar")
                {
                    AbrirConexion();
                    resultados = cmd.ExecuteNonQuery();
                }
                else
                {
                    AbrirConexion();
                    resultados = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error al tratar de guardar, borrar o modificar la base de datos", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultados;
        }
        public List<Equipos> listadoEquipos()
        {
            string orden = string.Empty;
            orden = "SELECT id_equipo, nombre FROM equipos;";
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            List<Equipos> ds = new List<Equipos>();

            try
            {
                AbrirConexion();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Equipos pEquipos = new Equipos();

                    pEquipos.pID = dr.GetInt32(0);
                    pEquipos.pNombre = (dr.GetString(1)).ToUpper();

                    ds.Add(pEquipos);
                }
                ds = ds.OrderBy(x => x.pID.ToString()[0]).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar equipos", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }

        public bool Control(string dato)
        {
            string orden = "SELECT COUNT(*) FROM equipos WHERE nombre = @nombre;";

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                cmd.Parameters.AddWithValue("@nombre", dato.ToUpper());

                try
                {
                    AbrirConexion();
                    int resultados = Convert.ToInt32(cmd.ExecuteScalar());

                    return resultados == 1;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar equipos. Detalles: " + ex.Message, ex);
                }
                finally
                {
                    CerrarConexion();
                }
            }
        }

        public DataTable listadoEquipos(string cual, int busqueda)
        {
            string orden = string.Empty;
            string idSql = string.Empty;
            if (busqueda == 3)
            {
                orden = "SELECT apellido as APELLIDO, nombre as NOMBRE, dni AS DNI, fecha_nac AS F_NAC, edad as EDAD FROM jugadores WHERE id_equipo=" + int.Parse(cual) + " ORDER BY apellido;";
            }
            else if (busqueda == 5)
            {

                // Consulta SQL para obtener el valor de id_equipo
                idSql = $"SELECT id_equipo FROM equipos WHERE nombre = '{cual}'";

                int cont = 0; // Valor predeterminado o manejo de error si no se encuentra ningún resultado

                using (MySqlConnection connection = new MySqlConnection(cadena)) // Reemplaza "connectionString" con tu cadena de conexión MySQL
                {
                    connection.Open();

                    using (MySqlCommand cmd2 = new MySqlCommand(idSql, connection))
                    {
                        object result = cmd2.ExecuteScalar();
                        if (result != null)
                        {
                            cont = Convert.ToInt32(result);
                        }
                    }

                    connection.Close();
                }

                // Ahora, 'cont' contiene el valor que obtuviste de la consulta SQL

                // Utilizar 'cont' en la consulta 'orden'
                orden = $"SELECT apellido, nombre, dni, edad FROM jugadores WHERE id_equipo = {cont} ORDER BY apellido;";

            }


            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            DataTable ds = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar jugadores", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
            
        }
        
        public Equipos BsquedaEquipo(string dato)
        {
            string orden = string.Empty;
            Equipos pEquipos = new Equipos();
            orden = "SELECT nombre, ruta_escudo from equipos where id_equipo=" + int.Parse(dato) + ";";
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            try
            {
                AbrirConexion();
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pEquipos.pNombre = (dr.GetString(0)).ToUpper();
                        pEquipos.pRuta = (dr.GetString(1)).ToLower();
                        
                    }
                }
                else
                {
                    Console.WriteLine("No se encontro jugador.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar jugador", ex);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return pEquipos;
        }
        public List<string> ListadoEquiposCopaPlata()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT equipo FROM equipoplata ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["equipo"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }

        public List<string> ListadoEquiposCopaPlataGoles()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol1 FROM equipoplata ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["gol1"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaPlataGolesSemis()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol2 FROM equipoplata ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["gol2"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaPlataGolesfinal()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol3 FROM equipoplata ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["gol3"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposPlayoff()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT DISTINCT E.nombre " +
                            "FROM posiciones P " +
                            "INNER JOIN equipos E ON E.id_equipo = P.id_equipo " +
                            "ORDER BY puntaje DESC, P.Dif_G DESC, P.G_fav DESC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["nombre"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaOro()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT equipo FROM equipooro ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["equipo"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaOroGoles()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol1 FROM equipooro ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                
                            string equipoNombre = reader["gol1"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaOroGolesSemis()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol2 FROM equipooro ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["gol2"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> ListadoEquiposCopaOroGolesFinal()
        {
            List<string> nombresEquipos = new List<string>();
            string query = "SELECT gol3 FROM equipooro ORDER BY idZona ASC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["gol3"].ToString(); // Elimina "equipos."
                            nombresEquipos.Add(equipoNombre);
                        }
                    }
                }
            }
            return nombresEquipos;
        }
        public List<string> listadoEquiposPlayoffplata()
        {
            List<string> equiposPlata = new List<string>();
            string query = "SELECT DISTINCT E.nombre " +
                            "FROM posiciones P " +
                            "INNER JOIN equipos E ON E.id_equipo = P.id_equipo " +
                            "ORDER BY puntaje DESC, P.Dif_G DESC, P.G_fav DESC";

            ClaseConexion ClaseConexion = new ClaseConexion();

            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena)) // Reemplaza "cadena" con tu cadena de conexión MySQL
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string equipoNombre = reader["nombre"].ToString(); // Elimina "equipos."
                            equiposPlata.Add(equipoNombre);
                        }
                    }
                }
            }
            return equiposPlata;
        }
    }
}
