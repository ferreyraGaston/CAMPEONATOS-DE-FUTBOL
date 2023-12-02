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

namespace CapaDatos
{
    public class ClaseSancion : ClaseConexion
    {
        public int abmSancion(string accion, int jugador, int fecha, int motivo)
        {
            int resultados = -1;
            string orden = string.Empty;

            switch (accion)
            {
                case "Amarilla":
                    orden = "INSERT INTO amarillas(dni_jugador, id_fecha) VALUES (@jugadorp, @fechap);";
                    break;
                case "Roja":
                    orden = "INSERT INTO rojas (dni_jugador, id_fecha, id_motivo) VALUES (@jugadorp, @fechap, @motivop);";
                    break;

                    // Agrega más casos según sea necesario
            }

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                cmd.Parameters.AddWithValue("@jugadorp", jugador);
                cmd.Parameters.AddWithValue("@fechap", fecha);
                if (accion == "Roja")
                {
                    cmd.Parameters.AddWithValue("@motivop", motivo);
                }

                try
                {
                    AbrirConexion();
                    resultados = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al tratar de realizar la acción '{accion}' en la base de datos", ex);
                }
                finally
                {
                    CerrarConexion(); 
                }
            }

            return resultados;
        }

        public List<(int IdMotivo, string Razon)> ListadoMotivo()
        {
            string orden = "SELECT id_motivo, razon FROM motivos;";
            List<(int IdMotivo, string Razon)> motivos = new List<(int, string)>();

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                try
                {
                    AbrirConexion();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int idMotivo = dr.GetInt32(0);
                            string razon = dr.GetString(1);
                            motivos.Add((idMotivo, razon));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener motivos", ex);
                }
                finally
                {
                    CerrarConexion();
                }
            }

            return motivos;
        }

        public List<int> ListadoTarjetasAmarillas(int equipo)
        {
            string orden = "SELECT amarillas.dni_jugador FROM amarillas JOIN jugadores ON amarillas.dni_jugador = jugadores.dni JOIN equipos ON jugadores.id_equipo = equipos.id_equipo WHERE equipos.id_equipo = " + equipo + ";";
            List<int> tarjetasAmarillas = new List<int>();

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                try
                {
                    AbrirConexion();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int dniJugador = dr.GetInt32(0);
                            tarjetasAmarillas.Add(dniJugador);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener tarjetas amarillas", ex);
                }
                finally
                {
                    CerrarConexion();
                }
            }

            return tarjetasAmarillas;
        }

        public List<int> ListadoTarjetasRojas(int equipo)
        {
            string orden = "SELECT rojas.dni_jugador FROM rojas JOIN jugadores ON rojas.dni_jugador = jugadores.dni JOIN equipos ON jugadores.id_equipo = equipos.id_equipo WHERE equipos.id_equipo = " + equipo + ";";

            List<int> tarjetasRojas = new List<int>();

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                try
                {
                    AbrirConexion();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            int dniJugador = dr.GetInt32(0);
                            tarjetasRojas.Add(dniJugador);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener tarjetas rojas", ex);
                }
                finally
                {
                    CerrarConexion();
                }
            }

            return tarjetasRojas;
        }
    }
}
