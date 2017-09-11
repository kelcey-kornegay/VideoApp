using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VideoApp.DTO
{
    public class MoviesDTO
    {
            public int Id { get; set; }

            [Required]
            [StringLength(255)]
            public string Name { get; set; }
        
            [Required]
            public int GenreId { get; set; }

            public DateTime? ReleaseDate { get; set; }

            public DateTime? DateAdded { get; set; }

            public GenreDTO Genre { get; set; }

            [Range(1,20)]
            public int NumberInStock { get; set; }


        
    }
}