using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class CommentModel
    {
        public CommentModel()
        {
            CommentAuthor = "Сержик";
            CommentText = "Прювет";
            CommentDate = DateTime.Now;
        
        }
    public string CommentAuthor{ get; set; }
    public string CommentText{ get; set; }
    public DateTime CommentDate { get; set;}
    
    }
}