using Shekho.Models;
using Shekho.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shekho.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random


        
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer{Name = "Jack",ID =1},
                new Customer{Name = "Roze",ID =2}
            };

            var ViewModel = new RandomViewMovieModel
            {
                Movie = movie,
                customers = customers
            };

            return View(ViewModel);
            
        }

        [Route("eerst/tweede/{year}/{month:range(1,12)}")]
        public ActionResult display(int year,int month)
        {
            return Content(year + "/" + month);
        }
        

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        /*public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Shekho";

            return Content(String.Format("pageIndex= {0} &sortBy={1}",pageIndex,sortBy));

        }*/
    }
}