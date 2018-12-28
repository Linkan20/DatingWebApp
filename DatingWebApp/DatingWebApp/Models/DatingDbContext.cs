using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DatingWebApp.Models
{
    public class DatingDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DatingDbContext() : base("DefaultConnection") { }
    }
}