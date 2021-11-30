using ScheduleDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleBL.Services
{
    public interface IScheduleService
    {
        Task<IEnumerable<Schedule>> GetAllAsync();
        Task<Schedule> GetByIdAsync(int id);
        Task<Schedule> CreateAsync(Schedule schedule);
        Task<bool> UpdateAsync(Schedule schedule);
        Task<bool> DeleteAsync(int id);

    }
}
