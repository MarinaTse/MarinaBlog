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
          
        }

        public RecentPosts(int UserID, DateTime ArticleDate, int CommentCount, string ArticlePreview, string ArticlePost) 
        {
               Author = UserID;
               Date = ArticleDate;
               CommentNumber = CommentCount;
               Post = ArticlePreview;
               ArticlePostMain = ArticlePost;
        
        }
        public int Author { get; set; } // string 
        public DateTime Date { get; set; }
        public int CommentNumber { get; set;}
        public string Post { get; set; }

        public string ArticlePostMain { get; set; }

    }

}