using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using IMDB.Models;
using IMDB.DL;
using System.Text;

namespace IMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly CRUDContext context;
        public HomeController(CRUDContext dbContext)
        {
            context = dbContext;

        }
        public IActionResult Index()
        {
            context.SeedMovie();
            return View(context.GetMovies());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        [HttpPost]
        public IActionResult PostData([FromBody]IMViewModel data)
        {
            
            if (ModelState.IsValid)
            {
                context.UpdateMovie(data);
                return new JsonResult(new { success = true, msg = "Success" });
            }
            else
            {
                var errors = new StringBuilder();
                foreach (ModelStateEntry modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errors.Append(error.ErrorMessage);
                    }
                }
                return new JsonResult(new { success = false, msg = errors.ToString() });
            }
        }
        [HttpPost]
        public IActionResult AddData([FromBody]IMViewModel data)
        {
            if (ModelState.IsValid)
            {
                context.AddMovie(data);
                return new JsonResult(new { success = true, msg="Success" });
            }
            else
            {
                var errors = new StringBuilder();
                foreach (ModelStateEntry modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errors.Append(error.ErrorMessage);
                    }
                }
                return new JsonResult(new { success = false , msg=errors.ToString()});
            }
        }
       
        public IActionResult Edit(int id)
        {
            if (id<=0)
            {
                return View();
            }
            return View(context.GetMovie(id));
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
