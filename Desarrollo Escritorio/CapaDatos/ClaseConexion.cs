using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClaseConexion
    {


       

        #region conexion
        public MySqlConnection conexion;
        //public string cadena = "datasource=sql200.infinityfree.com;port=3306;username=if0_35480126;password=hCF5HLcqQ9w;database=if0_35480126_CampeonatoDatos";
        //public string cadena = "datasource=db4free.net;port=3306;username=if0_35480126;password=hCF5HLcqQ9w;database=campeonatofutbol";
        //public string cadena = "datasource=192.168.100.65;port=3306;username=root;password=Lourdes04;database=campeonato2v2";
        public string cadena = "Server=localhost;Port=33065;Database=bdcampeonato;Uid=root;Password=;";

        #endregion
        #region constructor
        public ClaseConexion()
        {
            conexion = new MySqlConnection(cadena);
        }
        #endregion
        #region metodos abrir y cerrar conexion
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de abrir la conexión", ex);
            }
        }
        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de cerrar la conexión", ex);
            }
        }
        #endregion

    }
}
