using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ariansen.Models
{
    public class AriansenDB : DbContext
    {
        public DbSet<Blogger> Bloggers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}