using ScheduleDL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleDL.Repositories
{
    public class ScheduleRepository : IScheduleRepository
    {

        private readonly ScheduleContext _scheduleContext;

        public ScheduleRepository(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }

        public async Task<Schedule> CreateAsync(Schedule schedule)
        {
            _scheduleContext.Schedules.Add(schedule);
            await _scheduleContext.SaveChangesAsync();
            return schedule;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var element = _scheduleContext.Schedules.Attach(new Schedule { Id = id});
            var result = element != null;
            if(result)
            {
                _scheduleContext.Entry(element).State = EntityState.Deleted;
                await _scheduleContext.SaveChangesAsync();
            }
            return result;
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await _scheduleContext.Schedules.ToListAsync();
        }

        public async Task<Schedule> GetByIdAsync(int id)
        {
            return await _scheduleContext.Schedules.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Schedule schedule)
        {
            var element = _scheduleContext.Schedules.Attach(schedule);
            _scheduleContext.Entry(element).State = EntityState.Modified;
            await _scheduleContext.SaveChangesAsync();

            return element != null;
        }
    }
}
