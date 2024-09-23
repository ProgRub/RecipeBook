using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Services.Scrapers;
using Services.IndividualServices;
using Services;
using Services.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RecipeListController : Controller
    {
        // GET: RecipeList
        [Route("RecipeList")]
        [Route("CookBook")]
        public ActionResult Index()
        {
            return View(ServicesFacade.Instance.GetAllRecipes());
        }

        // GET: RecipeList/Recipe
        [Route("RecipeList/Recipe")]
        public ActionResult Recipe(int recipeID)
        {
            return View(ServicesFacade.GetRecipe(recipeID));
        }
    }
}
