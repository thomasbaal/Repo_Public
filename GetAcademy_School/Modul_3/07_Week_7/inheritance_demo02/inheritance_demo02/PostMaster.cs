using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_demo02
{
    public static class PostMaster
    {
        public static List<Post> LiallPosts { get; set; }

        static PostMaster()
        {
            LiallPosts = new List<Post>();
        }
        public static void AddPostToList(Post post)
        {
            LiallPosts.Add(post);
        }
    }
}
