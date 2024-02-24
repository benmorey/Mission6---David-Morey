using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Mission6___David_Morey.Models;
using System.Diagnostics;

namespace Mission6___David_Morey.Controllers
{
    public class HomeController : Controller
    {
        private CollectionContext _context; //Makes a variable to hold the database 

        public HomeController(CollectionContext temp)
        {
            _context = temp; //Holds the current database in a more perminant variable
        }

        public IActionResult Index()
        {
            return View(); //Renders the Home webpage
        }

        public IActionResult GettingToKnowJoel()
        {
            return View(); //Renders the About webpage
        }

        //Creates a GET and a POST method for the Movie Form webpage, so the records can be stored
        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();

            return View(new Movies());
        }

        [HttpPost]
        public IActionResult EnterMovie(Movies response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //Stores a record in the table
                _context.SaveChanges(); //Saves that addition to 'MovieDatabase.sqlite'

                return View("Submitted", response); //Returns a confirmation
            }
            else //Invalid Data
            {
                ViewBag.categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
                return RedirectToAction("EnterMovie", response);
            }

        }

        public IActionResult MovieIndex()  //This generates a table of all the recorded movies in the database
        {

            ViewBag.categories = _context.Categories.OrderBy(x => x.CategoryName).ToList(); //This holds all the data from the Category table, to later be linked in the Movies Table

            //Linq Query
            var display = _context.Movies.Where(x => x.Year >= 1888)
                .OrderBy(x => x.Title).ToList();

            return View(display);
        }

        [HttpGet]
        public IActionResult Edit(int id) //If you want to edit a row's data
        {
            var recordEdit = _context.Movies.Single(x => x.MovieID == id);

            ViewBag.categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();

            return View("EnterMovie", recordEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies m) //Pushing your changes into the database
        {
            _context.Update(m);
            _context.SaveChanges();

            return RedirectToAction("MovieIndex");
        }

        [HttpGet]
        public IActionResult Delete(int id) //If you want to delete a row
        { 
            var recordToDelete = _context.Movies.Single(x => x.MovieID == id);
            return View(recordToDelete); 
        }

        [HttpPost]
        public IActionResult Delete(Movies m) //Pushing your deletion to the databse
        {
            _context.Movies.Remove(m);
            _context.SaveChanges();

            return RedirectToAction("MovieIndex");
        }
    }
}
