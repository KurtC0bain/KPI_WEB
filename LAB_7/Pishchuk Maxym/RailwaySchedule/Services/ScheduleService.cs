using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RailwaySchedule.Models;

namespace RailwaySchedule.Services
{
    public class ScheduleService
    {
        private static int _id;
        private static List<Schedule> _schedules;
        static ScheduleService()
        {
            _id = 1;
            _schedules = new List<Schedule>
            {
                new Schedule
                {
                    Id = _id++,
                    TrainID = 092,
                    Route = "Kovel - Kyiv",
                    ArivalTime = new DateTime(2021, 12, 10, 00, 27, 0),
                    DepartureTime = new DateTime(2021, 12, 10, 00, 40, 0)
                },
                new Schedule
                {
                    Id = _id++,
                    TrainID = 806,
                    Route = "Lviv - Rivne",
                    ArivalTime = new DateTime(2021, 5, 10, 19, 01, 0),
                    DepartureTime = new DateTime(2021, 5, 10, 19, 05, 0)
                },

                new Schedule
                {
                    Id = _id++,
                    TrainID = 058,
                    Route = "Kovel - Odesa",
                    ArivalTime = new DateTime(2021, 5, 10, 22, 08, 0),
                    DepartureTime = new DateTime(2021, 5, 10, 22, 15, 0)
                }

            };

        }

        public void AddSchedule(Schedule schedule)
        {
            if (_schedules.Contains(schedule))
            {
                throw new InvalidOperationException("Schedule already exists");
            }
            schedule.Id = _id++;
            _schedules.Add(schedule);
        }
        public IEnumerable<Schedule> GetAllSchedules()
        {
            return _schedules;
        }
        public Schedule GetScheduleById(int id)
        {
            return _schedules.Find(s => s.Id == id);
        }
        public void Update(Schedule schedule)
        {
            var element = GetScheduleById(schedule.Id);
            if(element != null)
            {
                var index = _schedules.IndexOf(element);
                _schedules[index]= schedule;
            }
        }
        public bool Delete(int id)
        {
            var element = GetScheduleById(id);
            _id--;
            return _schedules.Remove(element);
        }
    }
}