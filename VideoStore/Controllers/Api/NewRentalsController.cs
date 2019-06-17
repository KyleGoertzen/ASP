using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoStore.Dtos;
using VideoStore.Models;

namespace VideoStore.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(RentalDto newRental)
        {
            /*
            if (newRental.MovieIds.Count == 0)
                return BadRequest("No Movie IDs have been given.");
            */

            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            /*
            if (customer == null)
                return BadRequest("Customer ID in not valid.");
            */

            // SELECT * FROM Movies WHERE Id IN (1, 2, 3)
            var movies = _context.Movies
                .Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            /*
            if (movies.Count != newRental.MovieIds.Count)
            {
                return BadRequest("One or more Movie IDs are invalid.");
            }
            */

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

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
