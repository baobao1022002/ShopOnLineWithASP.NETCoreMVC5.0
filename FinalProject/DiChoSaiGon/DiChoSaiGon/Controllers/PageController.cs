using DiChoSaiGon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;

namespace DiChoSaiGon.Controllers
{
    public class PageController : Controller
    {
        private readonly MarketsContext _context;
        public PageController(MarketsContext context)
        {
            _context = context;
        }


        //GET: page/Alias
        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if(string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
