using PeliculasAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositories
{
    public class OnMemoryRepository : IRepo
    {
        private List<Genres> _genres;

        public OnMemoryRepository()
        {
            _genres = new List<Genres>()
            {
                new Genres(){Id = 1, Name = "Comedy"},
                new Genres(){Id = 2, Name = "Horror"}
            };
        }

        public List<Genres> GetAllGenres()
        {
            return _genres;
        }

        public Genres GetById(int Id)
        {
            return _genres.FirstOrDefault(x => x.Id == Id);
        }
    }
}
