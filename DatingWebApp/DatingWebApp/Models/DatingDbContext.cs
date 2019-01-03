using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public partial class DatingDbContext : DbContext
    {
        public DbSet<ProfileModel> Profiles { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<FriendModel> Friends { get; set; }

        public DatingDbContext() : base("DatingDB"){ }
    }
}