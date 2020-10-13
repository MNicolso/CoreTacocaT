using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreTacocaT.Models;
using System.Text;

namespace CoreTacocaT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Code()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Solve()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Solve(string inputWord)
        {

            var resultTwo = new StringBuilder();
            if (string.IsNullOrWhiteSpace(inputWord))
            {

                return View();

            }
            var word = inputWord.Replace(" ", "").ToLower();
            var reverseWord = string.Join("", word.Reverse().ToArray());
            if(word==reverseWord)
            {
                resultTwo.Append(", that is a palindrome!"); 
            }
            else
            {
                resultTwo.Append(", that is a palindon'T!");
            }
            @ViewData["ResultTwo"] = resultTwo;
           @ViewData["Result"] = reverseWord;
            return View();

        }


            //[HttpPost]
            //public IActionResult TacoCat(string inputWord)
            //{
            //    var wordArray = inputWord.Split("");
            //    var reverseWord = string.Join("", wordArray.Reverse().ToArray());

            //    ViewData["result"]= string.Join("", wordArray.Reverse().ToArray());
            //    return View();
            //}



            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
