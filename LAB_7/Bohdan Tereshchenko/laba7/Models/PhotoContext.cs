using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace laba7.Models
{
    public class PhotoContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }

}