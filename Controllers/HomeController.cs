using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Vidly.Models;
using Vidly;

namespace Vidly2.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context = new DataContext();

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Home/Customers")]
        public IActionResult Customers()
        {

            var customer = _context.Customers.ToList();
            return View(customer);
        }

        public IActionResult CustomerProfile(int id)
        {

            var customer = _context.Customers.FirstOrDefault(c=> c.CustomerId == id);
            if (customer == null)
            {
                return View("404 Error");
            }
            return View(customer);
        }

        public IActionResult MovieProfile(int id)
        {

            var customer = _context.Movies.FirstOrDefault(m => m.Id == id);
            if (customer == null)
            {
                return View("404 Error");
            }
            return View(customer);
        }

        public IActionResult FormView()
        {
            var viewModel = new Customer();

           return View(viewModel);
        }
 
        public IActionResult AddMovie()
        {
                Movie movieModel = new Movie();
                return View(movieModel);
        }

        public IActionResult UpdateMovie(int id)
        {
            var movieToEdit = _context.Movies.FirstOrDefault(m => m.Id == id);
            return View(movieToEdit);
        }

        [HttpPost]
        public IActionResult SaveCustomer(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerId == 0)
                {
                    _context.Customers.Add(customer);
                }
                else
                {
                    _context.Customers.Update(customer);
                }
                _context.SaveChanges();
                return RedirectToAction("CustomerAdded", "Home");
            }
            else
            {
                return View("FormView");
            }
        }

        [HttpPost]
        public IActionResult SaveMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.Id == 0)
                {
                    _context.Movies.Add(movie);
                }
                else
                {
                    _context.Movies.Update(movie);
                }
                _context.SaveChanges();
                return RedirectToAction("MovieAdded", "Home");
            }
            else
            {
                return View("AddMovie");
            }
        }

        [Route("/MovieAdded")]
        public IActionResult MovieAdded()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
