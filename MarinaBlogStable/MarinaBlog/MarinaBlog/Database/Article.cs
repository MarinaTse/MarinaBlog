using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MarinaBlog.Database
{
    public class Article
    {
        [Key]
        public int PostID { get; set; }
        public string ArticlePost { get; set; }
        public string ArticleBody { get; set; }
        public string ArticlePreview { get; set; }
        public DateTime ArticleDate { get; set; }
        public int CommentCount { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public Users User { get; set; }
        public virtual ICollection<Comments> AllComments { get; set; }
    }
}