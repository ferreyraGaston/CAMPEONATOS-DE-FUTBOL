using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CapaDatos
{
    public class ClaseCopaOro
    {
        private CopaOro CopaOro = new CopaOro(); // Esto debería ser una instancia válida de CopaOro
        ClaseConexion ClaseConexion=new ClaseConexion();
        public int abmEquipos(string accion)
        {
            int resultado = -1;
            string orden = string.Empty;

            MySqlConnection conexion = new MySqlConnection(ClaseConexion.cadena); // Debes crear una nueva conexión MySqlConnection

            if (accion == "Agregar")
            {
                orden = "INSERT INTO equipoOro (idZona, equipo) VALUES (@idZona, @equipo)";
            }
            else if (accion == "AgregarCuartos")
            {
                orden = "INSERT INTO equipoOro (idZona, equipo, gol1) VALUES (@idZona, @equipo,@gol1)";
            }
            else if (accion == "AgregarCuartosPerdido")
            {
                orden = "UPDATE equipoOro SET idZona = @idZona, gol1 = @gol1 WHERE equipo = @equipo";
            }
            else if (accion == "AgregarSemi")
            {
                orden = "INSERT INTO equipoOro (idZona, equipo, gol2) VALUES (@idZona, @equipo,@gol2)";
            }
            else if (accion == "AgregarSemiPerdido")
            {
                orden = "UPDATE equipoOro SET gol2 = @gol2 WHERE equipo = @equipo";
            }
            else if (accion == "AgregarFinal")
            {
                orden = "INSERT INTO equipoOro (idZona, equipo, gol3) VALUES (@idZona, @equipo,@gol3)";
            }
            else if (accion == "AgregarFinalPerdido")
            {
                orden = "UPDATE equipoOro SET idZona = @idZona, gol3 = @gol3 WHERE equipo = @equipo";
            }

            if (!string.IsNullOrEmpty(orden))
            {
                MySqlCommand cmd = new MySqlCommand(orden, conexion);
                cmd.Parameters.AddWithValue("@idZona", CopaOro.IdZona);
                cmd.Parameters.AddWithValue("@equipo", CopaOro.Equipo);

                if (accion != "Agregar")
                {
                    cmd.Parameters.AddWithValue("@gol1", CopaOro.Gol1);

                    if (accion == "AgregarSemi")
                    {
                        cmd.Parameters.AddWithValue("@gol2", CopaOro.Gol2);

                        if (accion == "AgregarFinal")
                        {
                            cmd.Parameters.AddWithValue("@gol3", CopaOro.Gol3);
                        }
                    }
                }

                try
                {
                    conexion.Open(); // Debes abrir la conexión
                    resultado = cmd.ExecuteNonQuery();
                    Console.WriteLine("Éxito: " + resultado); // Mostrar el número de filas afectadas
                }
                catch (MySqlException ex)
                {
                    // Manejar la excepción, por ejemplo, registrándola o lanzándola nuevamente
                    Console.WriteLine("Error de MySQL: " + ex.Message);
                }
                finally
                {
                    conexion.Close(); // Debes cerrar la conexión
                }
            }

            return resultado;
        }
    }

}

