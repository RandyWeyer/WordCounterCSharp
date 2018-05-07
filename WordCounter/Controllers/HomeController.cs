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
          string word = Request.Form["word-input"];
          string listOfWords = Request.Form["list-of-words"];

          string sanitizedSentence = listOfWords.Replace("0","").Replace("1","").Replace("2","").Replace("3","").Replace("4","").Replace("5","").Replace("6","").Replace("7","").Replace("8","").Replace("9","").Replace("!","").Replace("@","").Replace("#","").Replace("$","").Replace("%","").Replace("^","").Replace("&","").Replace("*","").Replace("(","").Replace(")","").Replace(",","").Replace(".","").Replace(";","").Replace("[","").Replace("]","").Replace("-","").Replace("=","").Replace("<","").Replace(">","").Replace("?","").Replace(":","").Replace("{","").Replace("}","").Replace("_","").Replace("+","");

          Console.WriteLine(word);
          Console.WriteLine(sanitizedSentence);

          string[] sentence = sanitizedSentence.Split(' ');

          Console.WriteLine(sentence);

          WordCounter newWordCounter = new WordCounter (word, sentence);
          int NumberOfWords = newWordCounter.CountWords(word, sentence);
          return View("Index", NumberOfWords);
        }
    }
}
