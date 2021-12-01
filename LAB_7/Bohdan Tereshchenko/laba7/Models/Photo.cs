using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laba7.Models
{
    public class Photo
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Resolution { get; set; }
        public string Time { get; set; }
        public int? AlbumId { get; set; }
        public Album Album { get; set; }
    }
}