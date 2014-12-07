using MarinaBlog.Database;
using MarinaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarinaBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new RecentDataModel();
            using (var bd = new Context())
            {
                var user = new Users {UserName = "Manya"};
                bd.User.Add(user);
                bd.SaveChanges();

                //var comment = new Comments() { CommentBody = "Comment from database" };
                //bd.Comments.Add(comment);
                //bd.SaveChanges();
                var post = new Article()
                {
                    ArticlePost = "Первый пост из базы",
                    ArticleDate = DateTime.Now,
                    UserID = user.UserID
                };
                bd.Post.Add(post);
                bd.SaveChanges();
            }
            
            return View(model);
        }

        public ActionResult Post()
        {
            string query = Request.QueryString["Joo"];
            var Model = new ArticleModel();
            return View(Model); 
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult RecentComments() 
        {
            var model = new RecentDataModel();
            return View(model);
        }
        public ActionResult RecentPosts() 
        {
            var model = new RecentPosts();
            return View(model);
        }
    }
}
