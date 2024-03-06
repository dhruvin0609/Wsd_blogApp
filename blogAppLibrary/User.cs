using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace blogAppLibrary
{
    [DataContract]
    public class User
    {
        private int id;
        private string username;
        private string email;
        private string password;
        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string UserName
            { get { return username; } set { username = value; } }
        [DataMember]
        public string Email { get { return email; } set { email = value; } }
        [DataMember]
        public string Password { get { return password; } set { password = value; } }
    }
}
