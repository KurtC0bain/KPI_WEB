using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AudioRepositoryList
    {

        private static int _id;
        private static List<Audio> _audios;

        static AudioRepositoryList()
        {
            _id = 1;
            _audios = new List<Audio>()
            {
                new Audio()
                {
                    Id = _id++,
                    Name = "Znayesh Tanya",
                    Author = "Valentin Strykalo"
                },
                new Audio()
                {
                    Id = _id++,
                    Name = "21 Guns",
                    Author = "Green Day"
                }
            };
        }
        public AudioRepositoryList()
        {

        }

        public void Add(Audio audio)
        {
            audio.Id = _id++;
            _audios.Add(audio);

        }

        public IEnumerable<Audio> GetAllGoods()
        {
            return _audios;
        }

        public Audio GetGoodById(int id)
        {
            return _audios.Find(x => x.Id == id);
        }

        public void Update(Audio audio)
        {
            var element = _audios.Find(x => x.Id == audio.Id);

            if (element != null)
            {
                var index = _audios.IndexOf(element);
                _audios[index] = audio;
            }
        }

        public bool Delete(int id)
        {
            var element = _audios.Find(x => x.Id == id);

            return _audios.Remove(element);

        }
    }
}
