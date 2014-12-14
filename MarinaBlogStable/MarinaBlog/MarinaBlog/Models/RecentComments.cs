using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class RecentComments
    {
        public RecentComments()
        {
        }
    public RecentComments(DateTime CommentDate, string CommentBody, string UserName )
    {
        LastCommentDate = CommentDate;
        LastCommentText = CommentBody;
        LastCommentAuthor = UserName;
    
    }
    public string LastCommentText {get; set; }
    public string LastCommentURL { get; set; }
    public DateTime LastCommentDate { get; set;}
    public string LastCommentAuthor { get; set; }
    }

}