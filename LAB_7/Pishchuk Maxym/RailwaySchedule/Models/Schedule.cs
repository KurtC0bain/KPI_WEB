using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RailwaySchedule.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int TrainID { get; set; }
        public string Route { get; set; }
        public DateTime ArivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}