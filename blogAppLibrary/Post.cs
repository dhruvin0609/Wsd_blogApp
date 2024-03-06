using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace blogAppLibrary
{

        [DataContract]
        public class Post
        {
            private int id;
            private string title;
            private string content;
            private DateTime createdAt;
            private int userId;
            private string userName;

        [DataMember]
            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            [DataMember]
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            [DataMember]
            public string Content
            {
                get { return content; }
                set { content = value; }
            }

            [DataMember]
            public DateTime CreatedAt
            {
                get { return createdAt; }
                set { createdAt = value; }
            }

            [DataMember]
            public int UserId
            {
                get { return userId; }
                set { userId = value; }
            }
        [DataMember]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
    
}
