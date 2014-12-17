using MarinaBlog.Database;
using MarinaBlog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MarinaBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
    
        public ActionResult Index()
        {
            var model = new RecentDataModel();
            var db = new Context();
            var posetmodel = new Collection<RecentPosts>();            
            foreach (var item in db.Post.OrderByDescending(p => p.ArticleDate).Take(3).ToList())
            {
                var viewModel = new RecentPosts(item.UserID, item.ArticleDate, item.CommentCount, item.ArticlePreview, item.ArticlePost);
                posetmodel.Add(viewModel);
            }
            return View(posetmodel.AsEnumerable());
        }

        public ActionResult Post(string ArticlePost)
        {
           using (var db = new Context())
            {
                var post = db.Post.Where(p => p.ArticlePost == ArticlePost).FirstOrDefault();
                var commentModel = new Collection<CommentModel>();
                foreach(var item in post.AllComments)
                {
                    var commnet = new CommentModel(item.User.UserName,item.CommentBody,item.CommentDate);
                    commentModel.Add(commnet);
                }
                var model = new ArticleModel(post.ArticlePost,post.ArticleBody,post.ArticleDate,post.CommentCount,commentModel);
                return View(model);
            }
        }
        
        [HttpPost]
        [Authorize]
        public ActionResult AddComment(ArticleModel model, string ArticlePost) 
        {
            if (model.NewComment != null && ModelState.IsValid)
            {
                using (var db = new Context())
                {
                    var post = db.Post.Where(p => p.ArticlePost == ArticlePost).FirstOrDefault();
                    if (post != null)
                    {
                        var comment = new Comments() { CommentBody=model.NewComment.Comment, CommentDate=DateTime.Now };
                        db.Comment.Add(comment);
                        db.SaveChanges();

                    }
                    return RedirectToAction("Post", new { ArticlePost = ArticlePost });
                }
            }
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
    
        public ActionResult AddPost(Article model) 
        {
            using (var db = new Context())
            {
                model.ArticleDate = DateTime.Now;
                db.Post.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }
        [HttpPost]
         public ActionResult Login(UserModel model)
        {
            using (var db = new Context()) 
            { 
            var person = db.User.Where(h => h.Email==model.Email && h.Password == model.Password);
            if (person != null) 
            {
                var ticker = new FormsAuthenticationTicket(2, model.Email, DateTime.Now, DateTime.Now.AddMonths(1), true,
                    String.Empty);
                var encTicket = FormsAuthentication.Encrypt(ticker);

                var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                cookie.Expires = DateTime.Now.AddMonths(1);

                Response.Cookies.Add(cookie);

            }
            return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Registration(UserModel model)
        {
            using (var db = new Context())
            {
                var user = new Users{UserName = model.Name , Email = model.Email, Password = model.Password};
                db.User.Add(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

    }
}
