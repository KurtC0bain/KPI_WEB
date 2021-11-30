using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleDL.Models;

namespace ScheduleDL.Repositories
{
    public interface IScheduleRepository
    {
        Task<IEnumerable<Schedule>> GetAllAsync();
        Task<Schedule> GetByIdAsync(int id);
        Task<Schedule> CreateAsync(Schedule schedule);
        Task<bool> UpdateAsync(Schedule schedule);
        Task<bool> DeleteAsync(int id);

    }
}
