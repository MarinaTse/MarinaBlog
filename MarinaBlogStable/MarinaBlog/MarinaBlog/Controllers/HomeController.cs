using MarinaBlog.Database;
using MarinaBlog.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            if (ArticlePost == null)
            {
                ArticlePost = "Первый пост из базы";
            }
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
        [Authorize]
        [HttpPost]
        public ActionResult AddComment(ArticleModel model, string ArticlePost) 
        {
            if (model.NewComment != null && ModelState.IsValid)
            {
                using (var db = new Context())
                {
                    var post = db.Post.Where(p => p.ArticlePost == ArticlePost).FirstOrDefault();
                    if (post != null)
                    {
                        var comment = new Comments() { /*UserID =1, PostID=1,*/ CommentBody=model.NewComment.Comment, CommentDate=DateTime.Now };
                        db.Comment.Add(comment);
                        db.SaveChanges();

                    }
                    return RedirectToAction("Post", new { ArticlePost = ArticlePost });
                }
            }
            return View();
        }

        [HttpGet]
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

        public ActionResult Login() 
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Registration(Users model)
        {
            using (var db = new Context())
            {
                
                db.User.Add(model);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }

    }
}
