using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace blogAppLibrary
{
    public class CommentService:ICommentService
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=blogApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        ");
        void ICommentService.CreateComment(string content, int postId, int userId)
        {
            using (var dbConnection = _connection)
            {
                dbConnection.Open();
                using (var command = new SqlCommand("INSERT INTO [dbo].[Comment] (Content, CreatedAt, PostId, UserId) VALUES (@Content, @CreatedAt, @PostId, @UserId)", dbConnection))
                {
                    command.Parameters.AddWithValue("@Content", content);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                    command.Parameters.AddWithValue("@PostId", postId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
        }
        List<Comment>ICommentService.GetCommentsByPostId(int postId)
        {
            List<Comment> comments = new List<Comment>();

            using (var dbConnection = _connection)
            {
                dbConnection.Open();
                using (var command = new SqlCommand("SELECT Id, Content, CreatedAt, PostId, UserId FROM [dbo].[Comment] WHERE PostId = @PostId", dbConnection))
                {
                    command.Parameters.AddWithValue("@PostId", postId);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Comment comment = new Comment
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Content = reader["Content"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                                PostId = Convert.ToInt32(reader["PostId"]),
                                UserId = Convert.ToInt32(reader["UserId"])
                            };
                            comments.Add(comment);
                        }
                    }
                }
            }

            return comments;
        }
    }
}
