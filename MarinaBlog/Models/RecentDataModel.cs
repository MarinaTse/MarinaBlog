using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MarinaBlog.Models
{
    public class RecentDataModel
    {   
        public RecentDataModel()
        {
            LastDataComments = new Collection<RecentComments>();
                LastDataComments.Add(new RecentComments());
                LastDataComments.Add(new RecentComments());
                LastDataComments.Add(new RecentComments());
                LastDataComments.Add(new RecentComments());
                LastDataComments.Add(new RecentComments());
            LastDataPosts = new Collection<RecentPosts>();
                LastDataPosts.Add(new RecentPosts());
                LastDataPosts.Add(new RecentPosts());
                LastDataPosts.Add(new RecentPosts());
                LastDataPosts.Add(new RecentPosts());
        }
        public ICollection<RecentComments> LastDataComments { get; set; }
        public ICollection<RecentPosts> LastDataPosts  { get; set; }

    }
}