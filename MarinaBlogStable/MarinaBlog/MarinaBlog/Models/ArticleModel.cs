using MarinaBlog.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class ArticleModel
    {
        public ArticleModel()
        {
        }

       public ArticleModel(Article article) 
        { }
       public ArticleModel(string ArticlePost, string ArticleBody, DateTime ArticleDate, int CommentCount, ICollection<CommentModel> ArticleComments)
       {
           ArticleTitle = ArticlePost;
           ArticleText = ArticleBody;
           ArticleDateTime = ArticleDate;
           ArticleCommentsNumber = CommentCount;
           ArticleAllComments = ArticleComments;
       }

     public string ArticleText{ get; set; }
     public string ArticleTitle { get; set; }
     public DateTime ArticleDateTime { get; set; }
     public string ArticleAuthor { get; set; }
     public int ArticleCommentsNumber { get; set; }
     public ICollection<CommentModel> ArticleAllComments { get; set; }
     public AddCommentModel NewComment { get; set; }
    }
    
}