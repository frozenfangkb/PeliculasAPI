using PeliculasAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositories
{
    public interface IRepo
    {
        List<Genres> GetAllGenres();
        Task<Genres> GetById(int Id);
    }
}
