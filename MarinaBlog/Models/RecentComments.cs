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
              LastCommentDate = DateTime.Now;
              LastCommentURL = "http://google.com";
              LastCommentText = "Hello";
              LastCommentAuthor = "Predator";
        }
   
    public string LastCommentText {get; set; }
    public string LastCommentURL { get; set; }
    public DateTime LastCommentDate { get; set;}
    public string LastCommentAuthor { get; set; }
    }

}