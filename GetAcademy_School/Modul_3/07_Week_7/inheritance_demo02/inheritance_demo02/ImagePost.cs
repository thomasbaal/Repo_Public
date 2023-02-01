using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo02
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imageUrl, bool isPublic )
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.ImageURL = imageUrl;
            this.IsPublic = isPublic;

        }
    }
}
