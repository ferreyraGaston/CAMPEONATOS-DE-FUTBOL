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
    public class ClasePosiciones : ClaseConexion
    {
        public int abmPosicion(string accion, Posiciones objPosicion)
        {
            int resultados = -1;
            string orden = string.Empty;

            if (accion == "AgregarNuevo")
            {
                orden = "INSERT INTO posiciones(id_equipo) VALUES ('" + objPosicion.pID_Equi + "');";
            }
            if (accion == "Contar")
            {
                orden = "Select count (*) From equipos;";
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
        public List<Equipos> listadoPosiciones()
        {
            string orden = string.Empty;
            orden = "SELECT P.id_equipo, E.nombre FROM posiciones P, equipos E WHERE P.id_equipo=E.id_equipo ORDER BY P.puntaje;";
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
                //ds = ds.OrderBy(x => x.pNombre[0]).ToList();
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

        public DataTable listadoPosiciones(int busqueda)
        {
            string orden = string.Empty;
            if (busqueda == 1)
            {
                orden = "SELECT DISTINCT E.nombre, P.P_jug, P.P_gan, P.P_emp, P.P_per, P.G_fav, P.G_con, P.Dif_G, P.puntaje " +
                        "FROM posiciones P " +
                        "INNER JOIN equipos E ON E.id_equipo = P.id_equipo " +
                        "ORDER BY puntaje DESC, P.Dif_G DESC, P.G_fav DESC;";
            }
            else if (busqueda == 4)
            {
                orden = "SELECT DISTINCT L.id_libro AS COD, L.titulo AS TITULO, A.id_alumno AS SOC, A.nombre & ' ' & A.apellido AS POSEEDOR " +
                        "FROM libros L " +
                        "INNER JOIN detalle D ON L.id_libro = D.id_libro " +
                        "INNER JOIN prestamos P ON D.id_prestamo = P.id_prestamo " +
                        "INNER JOIN alumnos A ON P.id_alumno = A.id_alumno " +
                        "WHERE L.id_condicionLib = 2 AND P.devuelto = false " +
                        "ORDER BY L.id_libro;";
            }

            using (MySqlCommand cmd = new MySqlCommand(orden, conexion))
            {
                DataTable ds = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                try
                {
                    AbrirConexion();
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar jugadores", ex);
                }
                finally
                {
                    CerrarConexion();
                }

                return ds;
            }
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
    }
}
