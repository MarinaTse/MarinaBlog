using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarinaBlog.Database
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set;}
        //public ICollection<Article> Articles { get; set; }
    }
}