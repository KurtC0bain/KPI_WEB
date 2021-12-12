using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AudioService : IAudioService
    {
        private readonly IAudioRepository _audioRepository;
        public AudioService(IAudioRepository audioRepository)
        {
            _audioRepository = audioRepository;
        }
        public async Task<Audio> CreateAsync(Audio audio)
        {
            return await _audioRepository.CreateAsync(audio);            
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _audioRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Audio>> GetAllAsync()
        {
            return await _audioRepository.GetAllAsync();
        }

        public async Task<Audio> GetByIdAsync(int id)
        {
            return await _audioRepository.GetByIdAsync(id);   
        }

        public async Task<bool> UpdateAsync(Audio audio)
        {
            return await _audioRepository.UpdateAsync(audio); 
        }
    }
}
