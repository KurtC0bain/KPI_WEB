using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleDL.Models
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int TrainID { get; set; }
        public string Route { get; set; }
        [Required]
        public DateTime ArivalTime { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
    }
}