using EduHomeAPanel.DATA;
using EduHomeAPanel.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAPanel.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController (AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            List<Blog> blog = this._context.Blogs.ToList();
            return View(blog);
            
        }
    }
}
