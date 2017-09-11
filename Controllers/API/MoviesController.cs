using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoApp.DTO;
using VideoApp.Models;
using AutoMapper;

namespace VideoApp.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/movies

        public IEnumerable<MoviesDTO> GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies.Include(m => m.Genre)
                .Where(m => m.NumberAvailable > 0);

                if(!String.IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(m => m.Name.Contains(query));


            return moviesQuery
                    .ToList()
                    .Select(Mapper.Map<Movie,MoviesDTO>);

        }

        //GET /api/movie

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MoviesDTO>(movie));
        }


        //PUT /api/movies
        [HttpPut]
        public IHttpActionResult UpdateMovies(int id, MoviesDTO moviesDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map(moviesDTO, movieInDb);

            _context.SaveChanges();

            return Ok();
        }

        //POST /api/movies
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult CreateMovies(MoviesDTO movieDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDTO, Movie>(movieDTO);

            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDTO.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDTO);


        }
        
        //DELETE /api/movies/{int}

        public IHttpActionResult DeleteMovies(int id)
        {
            
            var moviesInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (moviesInDb == null)
                return NotFound();

            _context.Movies.Remove(moviesInDb);
            _context.SaveChanges();

            return Ok();

        }

        
    }
}
