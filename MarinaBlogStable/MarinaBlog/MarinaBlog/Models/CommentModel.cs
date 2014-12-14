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
        }

        public CommentModel(string UserName, string CommentBody, DateTime CommentDate) 
        {
            CommentAuthor = UserName;
            CommentText = CommentBody;
            CommentDateTime = CommentDate;
        }

    public string CommentAuthor{ get; set; }
    public string CommentText{ get; set; }
    public DateTime CommentDateTime { get; set; }
    
    }
}