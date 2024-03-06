using System;
using System.Runtime.Serialization;

namespace blogAppLibrary
{
    [DataContract]
    public class Comment
    {
        private int id;
        private string content;
        private DateTime createdAt;
        private int postId;
        private int userId;
        private string userName;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
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
        public int PostId
        {
            get { return postId; }
            set { postId = value; }
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
