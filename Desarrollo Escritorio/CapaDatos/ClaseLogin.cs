using MySql.Data.MySqlClient;
using System;



namespace CapaDatos
{

    public class ClaseLogin : ClaseConexion
    {
        ClaseConexion ClaseConexion= new ClaseConexion();
        public bool Login(string usuario, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(ClaseConexion.cadena))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
                catch (MySqlException ex)
                {
                    // Manejar la excepción específica de MySQL si es necesario
                    Console.WriteLine("Error de MySQL: " + ex.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    // Manejar otras excepciones generales
                    Console.WriteLine("Error general: " + ex.Message);
                    return false;
                }
                finally
                {
                    // Asegurarse de cerrar la conexión en cualquier caso
                    if (connection.State != System.Data.ConnectionState.Closed)

                    {
                        connection.Close();
                    }
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





