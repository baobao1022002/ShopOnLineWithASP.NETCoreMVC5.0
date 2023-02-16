using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiChoSaiGon.Models;
using PagedList.Core;
using DiChoSaiGon.Helpper;
using System.IO;
using AspNetCoreHero.ToastNotification.Abstractions;

namespace DiChoSaiGon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminNewsController : Controller
    {
        private readonly MarketsContext _context;
        public INotyfService _notifyService { get; }

        public AdminNewsController(MarketsContext context, INotyfService notifyService)
        {
            _context = context;
            _notifyService = notifyService;
        }

        // GET: Admin/AdminNews
        public IActionResult Index(int? page)
        {

            var collection = _context.News.AsNoTracking().ToList();
            foreach (var item in collection)
            {
                if (item.CreatedDate == null)
                {
                    item.CreatedDate= DateTime.Now;
        
                    _context.Update(item);
                    _context.SaveChanges();


                }
            }

            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsNews = _context.News.AsNoTracking().OrderByDescending(x => x.PostId);

            PagedList<News> models = new PagedList<News>(lsNews, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;

            return View(models);

        }


        // GET: Admin/AdminNews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: Admin/AdminNews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminNews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewFeed,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                // xử lí thumb
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string imageName = Utilities.SEOUrl(news.Title) + extension;
                    news.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                }

                if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                news.Alias = Utilities.SEOUrl(news.Title);
                news.CreatedDate= DateTime.Now;
                _context.Add(news);
                await _context.SaveChangesAsync();
                _notifyService.Success("Thêm tin thành công");
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: Admin/AdminNews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.FindAsync(id);
            if (news == null)
            {
                return NotFound();
            }
            return View(news);
        }

        // POST: Admin/AdminNews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostId,Title,Scontents,Contents,Thumb,Published,Alias,CreatedDate,Author,AccountId,Tags,CatId,IsHot,IsNewFeed,MetaKey,MetaDesc,Views")] News news, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != news.PostId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // xử lí thumb
                    if (fThumb != null)
                    {
                        string extension = Path.GetExtension(fThumb.FileName);
                        string imageName = Utilities.SEOUrl(news.Title) + extension;
                        news.Thumb = await Utilities.UploadFile(fThumb, @"news", imageName.ToLower());
                    }

                    if (string.IsNullOrEmpty(news.Thumb)) news.Thumb = "default.jpg";
                    news.Alias = Utilities.SEOUrl(news.Title);
                    news.CreatedDate = DateTime.Now;
                    _context.Update(news);
                    _notifyService.Success("Cập nhật tin thành công");

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.PostId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(news);
        }

        // GET: Admin/AdminNews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .FirstOrDefaultAsync(m => m.PostId == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: Admin/AdminNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.FindAsync(id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            _notifyService.Success("Xóa tin thành công");

            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.PostId == id);
        }
    }
}
