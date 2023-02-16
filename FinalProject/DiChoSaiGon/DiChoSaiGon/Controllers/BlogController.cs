using DiChoSaiGon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using System.Linq;

namespace DiChoSaiGon.Controllers
{
    public class BlogController : Controller
    {
        private readonly MarketsContext _context;
        public BlogController(MarketsContext context)
        {
            _context = context;
        }

        //GET: Blogs/Index
        [Route("blogs.html",Name ="Blog")]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsNews = _context.News.AsNoTracking().OrderByDescending(x => x.PostId);

            PagedList<News> models = new PagedList<News>(lsNews, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;

            return View(models);
        }

        //GET: Blogs/Details/5
        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinDetails")]
        public IActionResult Details(int id)
        {
            var tin = _context.News.AsNoTracking().SingleOrDefault(x=>x.PostId==id);
            if (tin == null)
            {
                return RedirectToAction("Index");
            }
            var lsBaiVietLienQuan=_context.News
                .AsNoTracking()
                .Where(x=>x.Published==true && x.PostId!=id)
                .Take(3).OrderByDescending(x=>x.CreatedDate)
                .ToList();
            ViewBag.BaiVietLienQuan= lsBaiVietLienQuan;
            return View(tin);
        }
    }
}
