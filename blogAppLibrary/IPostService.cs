using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace blogAppLibrary
{
    [ServiceContract]
    
    public interface IPostService
    {
        [OperationContract]
        void CreatePost(string title, string content, int userId);
        [OperationContract]
        void UpdatePost(int postId, string title, string content);
        [OperationContract]
        List<Post> GetAllPosts();
        [OperationContract]
        List<Post> GetPostsByUserId(int userId);
        [OperationContract]
        void DeletePost(int postId);
    }
}
