using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo02
{
    public class Post
    {
        private static int _currentPostId;


        //properties
        protected int Id { get; set; }
        private Guid _guid { get; set; }
        protected string Title { get; set; }
        public string SendByUserName { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            _guid = Guid.NewGuid();
            Id = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Thomas Bålsrød";
            PostMaster.AddPostToList(this);
        }

        public Post(string title, bool isPublic, string sendByUserName)
        {
            _guid= Guid.NewGuid();
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.IsPublic = isPublic;
            PostMaster.AddPostToList(this);
        }

        protected int GetNextId()
        {
            return ++_currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {

            return string.Format($"{this.Id} - {this.Title} - by {this.SendByUserName}\nGuid :{this._guid}");
        }

       
    }
}
