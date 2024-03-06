using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace blogAppLibrary
{
    [ServiceContract]
    public interface ICommentService
    {
        [OperationContract]
        void CreateComment(string content, int postId, int userId);

        [OperationContract]
        List<Comment> GetCommentsByPostId(int postId);
    }
}
