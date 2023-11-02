using Entidades;
using MySql.Data.MySqlClient;
using System;

namespace CapaDatos
{
    public class ClaseJugadores : ClaseConexion
    {
        public int abmJugadores(string accion, Jugadores objJugador)
        {

            int resultados = -1;
            string orden = string.Empty;
            if (accion == "Agregar")
            {
                orden = "INSERT INTO jugadores(nombre, apellido, fecha_nac, dni, edad, id_equipo) VALUES (@nombre, @apellido, @fechaNac, @dni, @edad, @equipos);";
            }
            if (accion == "Contar")
            {
                orden = "Select count (*) From jugadores;";
            }
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            try
            {
                if (accion != "Contar")
                {
                    cmd.Parameters.AddWithValue("@nombre", objJugador.pNombre.ToUpper());
                    cmd.Parameters.AddWithValue("@apellido", objJugador.pApellido.ToUpper());
                    cmd.Parameters.AddWithValue("@fechaNac", objJugador.pFechaNac);
                    cmd.Parameters.AddWithValue("@dni", objJugador.pDni);
                    cmd.Parameters.AddWithValue("@edad", objJugador.pEdad);
                    cmd.Parameters.AddWithValue("@equipos", objJugador.pEquipo);
                    AbrirConexion();
                    resultados = cmd.ExecuteNonQuery();
                }
                else
                {

                    AbrirConexion();
                    resultados = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
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
    }
}
