using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using MySql.Data;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;



namespace CapaDatos
{

    public class ClaseLogin : ClaseConexion
    {

        public bool Login(string usuario, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(cadena))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND password = @password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@password", password);


                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool InsertarUsuario(string usuario, string password, string nombre, string apellido, string dni, string clave)
        {
            using (MySqlConnection connection = new MySqlConnection(cadena))
            {
                connection.Open();

                string query = "INSERT INTO usuario (usuario, password, nombre, apellido, dni, clave) VALUES (@Usuario, @Password, @Nombre, @Apellido, @DNI, @Clave)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Clave", clave);

                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
} 
   
    



