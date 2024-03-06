using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace blogAppLibrary
{
    public class PostService : IPostService
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=blogApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
");
        void IPostService.CreatePost(string title, string content, int userId)
        {
            try
            {
                _connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = @"INSERT INTO [dbo].[Post] (Title, Content, UserId) VALUES (@Title, @Content, @UserId)";
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Content", content);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
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
        void IPostService.UpdatePost(int postId, string title, string content)
        {
            try
            {
                _connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = _connection;
                    command.CommandText = @"UPDATE [dbo].[Post] SET Title = @Title, Content = @Content WHERE Id = @PostId";
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Content", content);
                    command.ExecuteNonQuery();
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
        List<Post> IPostService.GetAllPosts()
        {
            List<Post> posts = new List<Post>();
            try
            {
                _connection.Open();
                using (var command = new SqlCommand("SELECT p.Id, p.Title, p.Content, p.CreatedAt, p.UserId, u.UserName " +
                                             "FROM [dbo].[Post] p " +
                                             "INNER JOIN [dbo].[User] u ON p.UserId = u.Id", _connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post post = new Post
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader["Title"].ToString(),
                            Content = reader["Content"].ToString(),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            UserName = reader["UserName"].ToString() // Assuming 'UserName' is the column name for the username in the User table
                        };
                        posts.Add(post);
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
            return posts;
        }
        List<Post> IPostService.GetPostsByUserId(int userId)
        {
            List<Post> posts = new List<Post>();
            try
            {
                _connection.Open();
                using (var command = new SqlCommand("SELECT Id, Title, Content, CreatedAt, UserId FROM [dbo].[Post] WHERE UserId = @UserId", _connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Post post = new Post
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                Content = reader["Content"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                UserId = Convert.ToInt32(reader["UserId"])
                            };
                            posts.Add(post);
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
            return posts;
        }


        void IPostService.DeletePost(int postId)
        {
            try
            {
                _connection.Open();
                using (var command = new SqlCommand("DELETE FROM [dbo].[Post] WHERE Id = @PostId", _connection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.ExecuteNonQuery();
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
    }
}
