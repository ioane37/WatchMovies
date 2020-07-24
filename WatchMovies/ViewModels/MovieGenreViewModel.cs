using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchMovies.Models;

namespace WatchMovies.ViewModels
{
    public class MovieGenreViewModel
    {
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}