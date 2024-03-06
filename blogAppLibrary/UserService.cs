using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace blogAppLibrary
{
    public class UserService : IUserService
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=blogApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
");
        void IUserService.CreateUser(string username, string email, string password)
        {

            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _connection;
                    cmd.CommandText = "INSERT INTO [user] (Username, Email, Password) VALUES (@username, @email, @password)";
                    SqlParameter p1 = new SqlParameter("@username", username);
                    SqlParameter p2 = new SqlParameter("@email", email);
                    SqlParameter p3 = new SqlParameter("@password", password);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);

                    _connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw; // Re-throw the exception to propagate it to the caller
            }
            finally
            {
                _connection.Close(); // Ensure connection is always closed
            }

        }

        User IUserService.GetUser(int id)
        {
            try
            {
                Console.Write("in get user");
                
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _connection;
                    cmd.CommandText = "SELECT * FROM [user] WHERE Id = @id";
                    SqlParameter p1 = new SqlParameter("@id", id);
                    cmd.Parameters.Add(p1);

                    _connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User
                            {
                                Id = reader.GetInt32(0),
                                UserName = reader.GetString(1),
                                Email = reader.GetString(2),
                                Password = reader.GetString(3)
                            };
                            return user;
                        }
                        else
                        {
                            // Handle case where user with given id is not found
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw; // Re-throw the exception to propagate it to the caller
            }
            finally
            {
                _connection.Close(); // Ensure connection is always closed
            }
        }
        int IUserService.Login(string email, string password)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = _connection;
                    cmd.CommandText = "SELECT Id FROM [User] WHERE Email = @email AND Password = @password";
                    SqlParameter p1 = new SqlParameter("@email", email);
                    SqlParameter p2 = new SqlParameter("@password", password);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);

                    _connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = (int)result;


                        // Return session id to client
                        return userId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        
    }
}
