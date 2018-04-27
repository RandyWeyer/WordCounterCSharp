using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterApp.Models;
using System;

namespace WordCounterApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/Submit")]
        public ActionResult Submit()
        {
          WordCounter newWordCounter = new WordCounter ((Request.Form["word-input"]), (Request.Form["list-of-words"]));
          int NumberOfWords = newWordCounter.CountWords((Request.Form["word-input"]), (Request.Form["list-of-words"]));
          return View("Index", NumberOfWords);
        }
    }
}
