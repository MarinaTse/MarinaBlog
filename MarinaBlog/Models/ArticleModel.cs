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
            ArticleTitle = "Моя первая запись";
            ArticleText = "Hello";
            ArticleDate = DateTime.Now;
            ArticleAuthor = "Маня";
            ArticleCommentsNumber = 3;
            ArticleAllComments = new Collection<CommentModel>( );
            
            ArticleAllComments.Add(new CommentModel());
            ArticleAllComments.Add(new CommentModel());
            ArticleAllComments.Add(new CommentModel());

                }
     public string ArticleText{ get; set; }
     public string ArticleTitle { get; set; }
     public DateTime ArticleDate { get; set; }
     public string ArticleAuthor { get; set; }
     public int ArticleCommentsNumber { get; set; }
     public ICollection<CommentModel> ArticleAllComments { get; set; }
    }
    
}