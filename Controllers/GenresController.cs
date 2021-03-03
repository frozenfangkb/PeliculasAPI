using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Entities;
using PeliculasAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepo repo;

        public GenresController(IRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        [HttpGet("list")]
        public List<Genres> Get()
        {
            return repo.GetAllGenres();
        }

        [HttpGet("{Id:int}")]
        public Genres Get(int Id)
        {
            Genres genre = repo.GetById(Id);

            if (genre == null)
            {
                //return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }

    }
}
