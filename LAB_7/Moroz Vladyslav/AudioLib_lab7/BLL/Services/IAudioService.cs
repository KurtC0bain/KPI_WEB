using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IAudioService
    {
        Task<Audio> CreateAsync(Audio audio);
        Task<IEnumerable<Audio>> GetAllAsync();
        Task<Audio> GetByIdAsync(int id);
        Task<bool> UpdateAsync(Audio audio);
        Task<bool> DeleteAsync(int id);
    }
}
