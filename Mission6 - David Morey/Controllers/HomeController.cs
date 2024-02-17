using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        public IActionResult EnterMovie(Collection response)
        {
            _context.Collection.Add(response); //Stores a record in the table
            _context.SaveChanges(); //Saves that addition to 'MovieDatabase.sqlite'

            return View("Submitted", response); //Returns a confirmation
        }
    }
}
