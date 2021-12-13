using EduHomeAPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAPanel.Controllers
{
    public class NewsLetterController : Controller
    {
        private readonly object _context;

        public IActionResult Index()
            {

            List<NewsLetter> newsletter = this._context.NewsLetters.ToList();
                return View(newsletter);

            }
           
        
    }
}
