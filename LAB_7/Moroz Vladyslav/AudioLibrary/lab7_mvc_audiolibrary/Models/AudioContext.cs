using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace lab7_mvc_audiolibrary.Models
{
    public class AudioContext: DbContext
    {
        public DbSet<Audio> AudioLibrary {  get; set; }
    }
}