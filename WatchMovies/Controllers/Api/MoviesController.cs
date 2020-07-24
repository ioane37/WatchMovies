using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WatchMovies.Models;
using WatchMovies.ViewModels;

namespace WatchMovies.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult GetMovie(int id) {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            MovieGenreViewModel targetMovie = new MovieGenreViewModel() {
                Movie = _context.Movies.SingleOrDefault(m => m.Id == id),
                Genre = _context.Genres.Single(g => g.Id == movie.GenreId)
            };

            return Ok(targetMovie);
        }
    }
}