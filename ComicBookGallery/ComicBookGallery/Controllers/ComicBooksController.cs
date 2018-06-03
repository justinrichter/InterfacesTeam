using ComicBookGallery.Models;
using ComicBookGallery.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRepository();
        }
        
        public ActionResult Detail(int? id)  //Base class is shared Result Type for ContentResult and RedirectResult
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRespository.GetComicBook((int)id);

            return View(comicBook);
        }
    }
}