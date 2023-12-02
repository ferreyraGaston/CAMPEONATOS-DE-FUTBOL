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
using Org.BouncyCastle.Asn1.X500;

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
            if (accion == "Modificar")
            {
                orden = "UPDATE jugadores SET nombre = @nombre, apellido = @apellido, fecha_nac = @fechaNac, edad = @edad, id_equipo = @equipos WHERE dni = @dni";
            }
            if (accion == "Eliminar")
            {
                orden = "DELETE FROM jugadores WHERE dni = @dni";
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

        public string ObtenerEquipoPorDni(int dni)
        {
            string equipo = ""; // Valor predeterminado si no se encuentra el DNI
            string orden = "SELECT E.nombre FROM jugadores J INNER JOIN equipos E ON J.id_equipo = E.id_equipo WHERE J.dni = @Dni";

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                try
                {
                    conexion.Open();
                    cmd.Parameters.AddWithValue("@Dni", dni);

                    // Utiliza ExecuteScalar para obtener un solo valor
                    var resultado = cmd.ExecuteScalar();

                    // Verificar si se encontró un resultado
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        equipo = resultado.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (puedes mostrar un mensaje, loggear, etc.)
                    throw new Exception("Error al consultar la base de datos.", ex);
                }
                finally
                {
                    // Cerrar la conexión en el bloque finally
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }


            return equipo;
        }
    }
}
