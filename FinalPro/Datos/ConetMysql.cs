using FinalPro.Datos.Parametros;
using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace FinalPro.Datos
{
    internal class ConetMysql
    {
        string connectionString = "server=localhost;database=examenfinall;Uid=root;password=Kemanol4";
        private MySqlConnection connection;

        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }


        }

        public DataTable LeerConetMysql()
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM examenfinall.personajes ";
                using (MySqlCommand commnd = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(commnd))
                    {
                        adapter.Fill(personaje);
                    }

                }



            }
            return personaje;

        }

        public int AñadirPersonaje(string nombrep, string animep, DateTime fechae, string cantidade, string cantidadt, bool emision, bool finalizado)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (string.IsNullOrEmpty(nombrep))
                    {
                        MessageBox.Show("Error: El campo 'Nombre del Personaje' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(animep))
                    {
                        MessageBox.Show("Error: El campo 'Anime que Pertenece' no puede estar vacío.");
                        return -1;
                    }

                    if (fechae == DateTime.MinValue)
                    {
                        MessageBox.Show("Error: Debe ingresar una fecha de Emision valida.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(cantidade) || !double.TryParse(cantidade, out _))
                    {
                        MessageBox.Show("Error: El campo 'Cantidad de Episodios' no puede estar vacío.");
                        return -1;
                    }

                    if (string.IsNullOrEmpty(cantidadt) || !double.TryParse(cantidadt, out _))
                    {
                        MessageBox.Show("Error: El campo 'Cantidad de Temporadas' no puede estar vacío.");
                        return -1;
                    }


                    string query = "INSERT INTO examenfinall.personajes (nombrep, animep, fechae, cantidade, cantidadt, emision, finalizado) VALUES (@nombrep, @animep, @fechae, @cantidade, @cantidadt, @emision, @finalizado)";

                    using (MySqlCommand commnd = new MySqlCommand(query, connection))
                    {
                        commnd.Parameters.AddWithValue("@nombrep", nombrep);
                        commnd.Parameters.AddWithValue("@animep", animep);
                        commnd.Parameters.AddWithValue("@fechae", fechae);
                        commnd.Parameters.AddWithValue("@cantidade", cantidade);
                        commnd.Parameters.AddWithValue("@cantidadt", cantidadt);
                        commnd.Parameters.AddWithValue("@emision", emision);
                        commnd.Parameters.AddWithValue("@finalizado", finalizado);


                        return commnd.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al añadir personaje: " + ex.Message);
                    throw;
                }
                finally { connection.Close(); }
            }

        }


        public int EliminarPersonaje(int ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "DELETE FROM examenfinall.personajes WHERE ID = @ID";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        int no = command.ExecuteNonQuery();
                        if (no == 0)
                        {
                            MessageBox.Show("Error: No se encontro ningun personaje con el id ingresado");
                        }

                        return command.ExecuteNonQuery();
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Error al eliminar personaje " + ex.Message);
                    throw;
                }
                finally { connection.Close(); }
            }
        }

        public int ActualizarPersonaje(int ID, string nombrep, string animep, DateTime fechae, string cantidade, string cantidadt, bool emision, bool finalizado)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {


                // Actualizar el registro en la base de datos
                try
                {
                    connection.Open();

                    string query = "UPDATE examenfinall.personajes SET nombrep = @nombrep, animep = @animep, fechae = @fechae, cantidade = @cantidade, cantidadt = @cantidadt, emision = @emision, finalizado = @finalizado  WHERE ID = @ID";

                    using (MySqlCommand commnd = new MySqlCommand(query, connection))
                    {
                        commnd.Parameters.AddWithValue("@nombrep", nombrep);
                        commnd.Parameters.AddWithValue("@animep", animep);
                        commnd.Parameters.AddWithValue("@fechae", fechae);
                        commnd.Parameters.AddWithValue("@cantidade", cantidade);
                        commnd.Parameters.AddWithValue("@cantidadt", cantidadt);
                        commnd.Parameters.AddWithValue("@emision", emision);
                        commnd.Parameters.AddWithValue("@finalizado", finalizado);
                        commnd.Parameters.AddWithValue("@ID", ID);

                        return commnd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    return -1;
                }
            }
        }

      


    }
}
