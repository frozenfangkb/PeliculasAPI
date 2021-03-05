using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Entities
{
    public class Genres
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Field {0} is required")]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
    }
}
