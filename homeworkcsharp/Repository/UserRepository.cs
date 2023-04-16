using MySql.Data.MySqlClient;
using System;

namespace homeworkcsharp.Repository
{
    class UserRepository
    {

        protected readonly string connectionString;

        public UserRepository()
        {
            this.connectionString = "server=localhost;user=root;password=;database=mvc;"; ;
        }

        public void InsertarRegistro(Models.User user)
        {

            if (this.ValidatorData(user))
            {

                System.Windows.Forms.MessageBox.Show("¡Lo sentimos, Hora de la cita ya ha sido tomada.!");
                return;

            };

            string query = "INSERT INTO users (name, idNumber, doctor, speciality, datetime, hour) VALUES (@name, @idNumber, @doctor, @speciality, @datetime, @hour)";
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = this.connectionString;


            try
            {
                connection.Open();

                MySqlCommand comando = new MySqlCommand(query, connection);

                comando.Parameters.AddWithValue("@name", user.Name);
                comando.Parameters.AddWithValue("@idNumber", user.IdNumber);
                comando.Parameters.AddWithValue("@doctor", user.Doctor);
                comando.Parameters.AddWithValue("@speciality", user.Speciality);
                comando.Parameters.AddWithValue("@datetime", user.DateTime);
                comando.Parameters.AddWithValue("@hour", user.Hour);

                int result = comando.ExecuteNonQuery();

                if (result > 0)
                {
                    System.Windows.Forms.MessageBox.Show("¡Registro insertado correctamente.!");
                    //Console.WriteLine("Registro insertado correctamente.");
                }
                else
                {
                    Console.WriteLine("No se pudo insertar el registro.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public System.Data.DataTable ObtenerDatos()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = this.connectionString;

            string query = "SELECT name as Nombre, idNumber as Identificación, doctor as Doctor, datetime as Fecha, hour as Hora FROM users";
            System.Data.DataTable dt = new System.Data.DataTable();

            try
            {
                connection.Open();
                MySqlCommand comando = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public bool ValidatorData(Models.User user)
        {
            bool existe = false;
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = this.connectionString;

            try
            {
                connection.Open();

                MySqlCommand comando = new MySqlCommand("SELECT COUNT(*) FROM users WHERE datetime = @datetime AND hour = @hour AND doctor = @doctor", connection);
                comando.Parameters.AddWithValue("@datetime", user.DateTime);
                comando.Parameters.AddWithValue("@hour", user.Hour);
                comando.Parameters.AddWithValue("@doctor", user.Doctor) ;

                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                existe = (cantidad > 0);

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(existe);
            return existe;
        }
    }
}
