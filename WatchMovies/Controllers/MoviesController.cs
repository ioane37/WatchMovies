using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchMovies.Models;
using WatchMovies.ViewModels;
using System.Data.Entity;

namespace WatchMovies.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        public ActionResult MovieForm(int id) {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            MovieGenreViewModel movieGenreViewModel = new MovieGenreViewModel() {
                Movie = movie,
                Genre = _context.Genres.Single(g => g.Id == movie.GenreId)
            };

            return View(movieGenreViewModel);
        }

        public ActionResult New() {
            return View(new NewMovieViewModel() { Genre = _context.Genres.ToList() });
        }

        [HttpPost]
        public ActionResult Save(HttpPostedFileBase file, HttpPostedFileBase actualMovie, Movie movie) {
            MemoryStream target = new MemoryStream();
            file.InputStream.CopyTo(target);
            byte[] imageData = target.ToArray();
            movie.Image = imageData;

            MemoryStream movieTarget = new MemoryStream();
            actualMovie.InputStream.CopyTo(movieTarget);
            byte[] movieData = movieTarget.ToArray();
            movie.ActualMovie = movieData;
            movie.DateAdded = DateTime.Now;

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}