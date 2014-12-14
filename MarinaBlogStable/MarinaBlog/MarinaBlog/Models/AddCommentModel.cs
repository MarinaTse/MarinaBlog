using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarinaBlog.Models
{
    public class AddCommentModel
    {
        public string Comment { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
    }
}
