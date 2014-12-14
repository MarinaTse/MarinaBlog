
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MarinaBlog.Database
{
    public class Context : DbContext
    {
        public Context()
            : base("DataBaseConnection")
        {     
        }
              public DbSet<Article> Post { get; set;}
              public DbSet<Comments> Comment { get; set;} 
              public DbSet<Users> User { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           // modelBuilder.Entity<Article>().HasRequired(mod => mod.User).WithMany(mod => mod.Articles).HasForeignKey(mod => mod.UserID);
            //modelBuilder.Entity<Article>().HasMany(mod => mod.AllComments).WithRequired(mod => mod.Article).HasForeignKey(mod => mod.PostID);
        }
    }
}