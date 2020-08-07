using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult MovieForm()
        {
            var genre = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Genres = genre
            };

            return View("MovieFormNew", viewModel);

        }
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        [HttpPost]
        public ActionResult Save(Movie movie) 
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel(movie)
                { 
                    Genres = _context.Genres.ToList()
                };
                return View("MovieFormNew", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                movie.NumberAvailable = movie.NumberInStock;  //yaad h kuch bsdk
                _context.Movies.Add(movie);
            }

            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }


        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            { 

                Genres = _context.Genres.ToList()

            };
            return View("MovieForm", viewModel);
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "kala shah" };
            var customers = new List<Customer>
            {
                new Customer { Name = "customer 1"},
                new Customer { Name = "customer 2"}
            };

            var viewmodel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewmodel);
        }

            /* like we using view(movie) to pass/or view data ...we have another way to view data--->
             * 1.> ViewData method 
             *  syntax -->ViewData["Movie"] = movie; but it has quite complex code in View file(i.e random.cshtml file)..code is <h2>@((Movie) ViewData["Movie"]).Name)</h2>
             * 2.> Viewbag method which is update of 1st method and it is dynamic 
             *  syntax --> Viewbag.Movie =  movie; but it has casting issue as well and also if we change name of module,eg -> Viewbag.randommovie = movie;noww manually we need to change
             * this in view file also as that of 1st method...so instead of this both fuckin methods ,return View(movie); is best.
        

        /*
         * Action Results--->
         * type------------------------helper method
         * ViewResult               ---view()
         * PartialViewResult        ---PartialView()
         * ContentResult            ---Content()
         * Redirect Result          ---Redirect()
         * RedirectToRouteResult    ---RedirectToAction()
         * JsonResult               ---json()
         * FileResult               ---file()
         * HttpNotFoundResult       ---HttpNotFound()
         * EmptyResult
         * 
         *eg--return new EmptyResult();    eg --> return view(movie); as same as we do in previous
         */

        // movies/edit/Id
       /* public ActionResult edit(int Id)

        {
            return Content("id=" + Id);
        }
     */    
        // movies/
        /*
         * as index action method is already defined, so not getting confuse to movies controller.. i will do multiple statements here. 
         * public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        */
        /*
        [Route("movies/released/{Year:regex(\\d{4}):range(1980,2020)}/{Month:regex(\\d{2}):range(1,12)}")]  //attribute route
        // like range , we have many constraints like min,max,minlength,maxlength,int,float,guid
        public ActionResult Byreleasedate(int Year, int Month)
        {
            return Content(Year + "/" + Month);
        }
        */
    
    }
}

