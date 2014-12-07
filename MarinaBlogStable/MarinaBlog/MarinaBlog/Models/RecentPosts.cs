using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class RecentPosts
    {
        public RecentPosts()
        {
            Author = "Manichka";
            Date = DateTime.Now;
            CommentNumber = 3;
            Post = "Здесь краткое содержимое поста";
            ArticlePost = "Мой пост";
        }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int CommentNumber { get; set;}
        public string Post { get; set; }

        public string ArticlePost { get; set; }

    }

}