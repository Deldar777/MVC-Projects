using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shekho.Models;

namespace Shekho.ViewModels
{
    public class RandomViewMovieModel
    {
        public Movie Movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}