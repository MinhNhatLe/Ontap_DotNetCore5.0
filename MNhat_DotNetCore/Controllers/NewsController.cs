using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MNhat_DotNetCore.Controllers
{
    public class NewsController : Controller
    {
        // GET: NewsController
        public ActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article {ID = 1, Title = "Title 01", Content="Content 01", Author = "Nhat"},
                new Article {ID = 2, Title = "Title 02", Content="Content 02", Author = "Nhat"},
                new Article {ID = 3, Title = "Title 03", Content="Content 03", Author = "Nhat"},
                new Article {ID = 4, Title = "Title 04", Content="Content 04", Author = "Nhat"},
                new Article {ID = 5, Title = "Title 05", Content="Content 05", Author = "Nhat"},
                new Article {ID = 6, Title = "Title 06", Content="Content 06", Author = "Nhat"},
                new Article {ID = 7, Title = "Title 07", Content="Content 07", Author = "Nhat"},
                new Article {ID = 8, Title = "Title 08", Content="Content 08", Author = "Nhat"},
                new Article {ID = 9, Title = "Title 09", Content="Content 09", Author = "Nhat"},
            };
            //1. ViewBag - Kh cần ép kiểu
            //ViewBag.Article = articles;


            //2. ViewData- Phải ép kiểu
            //ViewData["Articles"] = articles;

            //3 Dữ liệu lớn - để articles vào View luôn
            return View(articles);
        }

        public class Article 
        {
            public int ID { set; get; }
            public string Title { set; get; }
            public string Content { set; get; }
            public string Author { set; get; }
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
