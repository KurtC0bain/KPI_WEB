using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba7.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public ICollection<Photo> Photos { get; set; }
        public Album()
        {
            Photos = new List<Photo>();
        }
    }
}