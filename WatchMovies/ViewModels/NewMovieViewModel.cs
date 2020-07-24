using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchMovies.Models;

namespace WatchMovies.ViewModels
{
    public class NewMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genre { get; set; }
    }
}