using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebApp.Controllers
{
    public class ScrapeRecipeController : Controller
    {
        // GET: ScrapeRecipeController
        [Route("ScrapeRecipe")]
        public ActionResult Index()
        {
            return View();
        }

        // POST: ScrapeRecipeController/Scrape
        [HttpPost("ScrapeRecipe/Scrape")]
        [ValidateAntiForgeryToken]
        public ActionResult Scrape(IFormCollection collection)
        {
            Debug.WriteLine("HERE");
            Debug.WriteLine(collection["url"]);

            return RedirectToAction("Index");
        }
    }
}
