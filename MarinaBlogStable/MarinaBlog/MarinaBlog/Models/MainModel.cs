using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class MainModel
    {
        public MainModel() {
            Article = new ArticleModel();
            RecentPosts = new RecentDataModel();
            RecentComments = new RecentDataModel();
            Comments = new CommentModel();     
        }
        public ArticleModel Article { get; set; }
        public RecentDataModel RecentPosts { get; set; }
        public RecentDataModel RecentComments { get; set; }
        public CommentModel Comments { get; set; }

    }
}