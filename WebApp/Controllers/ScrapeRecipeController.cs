﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Services.Scrapers;
using Services.IndividualServices;
using Services;
using Services.DTOs;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ScrapeRecipeController : Controller
    {
        // GET: ScrapeRecipe
        [Route("ScrapeRecipe")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: ScrapeRecipe
        [Route("ScrapeRecipe/Result")]
        public ActionResult Result()
        {
            RecipeDTO recipe = ViewData["Recipe"] as RecipeDTO;
            Debug.WriteLine(recipe.Name);
            return View(recipe);
        }

        // POST: ScrapeRecipeController/Scrape
        [HttpPost("ScrapeRecipe/Scrape")]
        [ValidateAntiForgeryToken]
        public ActionResult Scrape(IFormCollection collection)
        {
            var recipe = ServicesFacade.GetRecipe(collection["url"]);
            ViewData["Recipe"] = recipe;
            return RedirectToAction("Index");
        }

        // POST: ScrapeRecipeController/SaveRecipe
        [HttpPost("ScrapeRecipe/Result")]
        [ValidateAntiForgeryToken]
        public ActionResult SaveRecipe()
        {
            Debug.WriteLine("HERE");
            //ServicesFacade.SaveDatabase();

            return RedirectToAction("Index");
        }
    }
}
