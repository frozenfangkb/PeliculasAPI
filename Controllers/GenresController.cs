using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PeliculasAPI.Entities;
using PeliculasAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/genres")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenresController : ControllerBase
    {
        private readonly AppDbContext context;

        public GenresController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [HttpGet("list")]
        public async Task<List<Genres>> Get()
        {
            return await context.Genres.ToListAsync();
        }

        /*[HttpGet("{Id:int}")]
        public async Task<ActionResult<Genres>> Get(int Id)
        {
            
        }*/

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Genres genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genres genre)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }

    }
}
