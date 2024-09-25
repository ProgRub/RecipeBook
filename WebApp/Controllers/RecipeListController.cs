using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Services.Scrapers;
using Services.IndividualServices;
using Services;
using Services.DTOs;
using WebApp.Models;
using Database.Entities;

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

		// POST: RecipeList/Recipe
		[HttpPost("RecipeList/Recipe")]
		public ActionResult Scale(int recipeID,double scaleValue)
		{
			return View("Recipe",ServicesFacade.GetScaledRecipe(ServicesFacade.GetRecipe(recipeID), scaleValue));
		}
	}
}
