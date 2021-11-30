using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ScheduleDL.Models;
using ScheduleDL.Repositories;

namespace ScheduleBL.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }
        public async Task<Schedule> CreateAsync(Schedule schedule)
        { 
            return await _scheduleRepository.CreateAsync(schedule);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _scheduleRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await _scheduleRepository.GetAllAsync();
        }

        public async Task<Schedule> GetByIdAsync(int id)
        {
            return await _scheduleRepository.GetByIdAsync(id);
        }

        public async Task<bool> UpdateAsync(Schedule schedule)
        {
            return await _scheduleRepository.UpdateAsync(schedule);
        }
    }
}