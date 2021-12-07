using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab7_mvc_audiolibrary.Models
{
    public class Audio
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Album { get; set; }
        public string Description { get; set; }

        public ICollection<Audio> Audios { get; set;}

        public Audio()
        {
            Audios = new List<Audio>();
        }
    }
}