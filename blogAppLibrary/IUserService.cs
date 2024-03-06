using System;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Web;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blogAppLibrary
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void CreateUser(String username, String email, String password);

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        int Login (string email, string password);

        
    }
}
