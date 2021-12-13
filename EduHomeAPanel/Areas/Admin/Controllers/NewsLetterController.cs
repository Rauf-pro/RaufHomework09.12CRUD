using EduHomeAPanel.DATA;
using EduHomeAPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAPanel.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsLetterController : Controller
    {
        private readonly AppDbContext _context;

        public NewsLetterController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<NewsLetter> model = _context.NewsLetters.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            List<NewsLetter> model = _context.NewsLetters.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(string Title, string SubTitle, string Email, DateTime CreatdedDate)
        {
            List<NewsLetter> model = _context.NewsLetters.ToList();
            return View(model);
        }


    }
}
