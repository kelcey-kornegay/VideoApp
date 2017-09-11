using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoApp.Models;
using VideoApp.DTO;


namespace VideoApp.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST create order
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDTO newRental)
        {
            /*if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie Id given");*/

            var customer = _context.Customers.
                Single(c => c.Id == newRental.CustomerId);

            if (customer == null)
                return BadRequest("customer id is invalid");

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();
            
            if(movies.Count != newRental.MovieIds.Count)
                return BadRequest("One or more movie id are invalid");

            foreach(var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie out of stock");

                movie.NumberAvailable--;

                var rental = new Rental

                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }
           
            
    }
}
