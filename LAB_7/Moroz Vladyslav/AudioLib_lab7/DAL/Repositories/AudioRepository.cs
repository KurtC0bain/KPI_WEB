using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AudioRepository : IAudioRepository
    {
        private readonly AudioContext _audioContext;

        public AudioRepository(AudioContext audioContext)
        {
            _audioContext = audioContext;
        }

        public async Task<Audio> CreateAsync(Audio audio)
        {
            _audioContext.Audios.Add(audio);

            await _audioContext.SaveChangesAsync();

            return audio;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = _audioContext.Audios.Attach( new Audio { Id = id } );
            var result = item != null;
            if (result)
            {
                _audioContext.Entry(item).State = EntityState.Deleted;
                await _audioContext.SaveChangesAsync();
            }
            return result;
        }

        public async Task<IEnumerable<Audio>> GetAllAsync()
        {
            return await _audioContext.Audios.ToListAsync();
        }

        public async Task<Audio> GetByIdAsync(int id)
        {
            return await _audioContext.Audios.FindAsync( id );
        }

        public async Task<bool> UpdateAsync(Audio audio)
        {
            var item = _audioContext.Audios.Attach(audio);
            _audioContext.Entry(item).State = EntityState.Modified;
            await _audioContext.SaveChangesAsync();
           
            return item != null;
        }
    }
}
