using Microsoft.AspNetCore.Mvc;
using BtkAkademi.Models;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult  Index()
        {
            var model = Repository.Aplications;
            return View(model);
        }

         public IActionResult  Apply() 
        {
            // GET
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // hangi arayiciyla istek yaptigini veri sahteciligne karsi dogrula

                                    // verinin nerden gelcegini sectik [FromForm]
        public IActionResult Apply([FromForm]Candidate model)
        {

            Repository.Add(model);
            return View("Feedback",model);

            // POST

        }
    }
    
}