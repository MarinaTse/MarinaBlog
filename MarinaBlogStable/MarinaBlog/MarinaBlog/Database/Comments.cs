using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarinaBlog.Database
{
 
    public class Comments
    {
        public Comments()  
        {

        } 
    
public Comments(int UserID, int PostID, string CommentBody,DateTime CommentDate)
{
    this.UserID=UserID;
    this.PostID=PostID;
    this.CommentBody=CommentBody;
    this.CommentDate=CommentDate;
}     

        public int UserID { get; set; }
        public int PostID { get; set; }
        [Key]
        public int CommentID { get; set; }

        public string CommentBody { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual Users User { get; set; }

        //public virtual Article Article { get; set; }
                
    }
}