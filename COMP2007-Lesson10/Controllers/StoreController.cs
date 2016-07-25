using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_Lesson10.Models;

namespace COMP2007_Lesson10.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreContext storeDB = new MusicStoreContext();
            
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();

            return View(genres);
        }

        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre)
        {
            Genre genreModel = new Genre(genre);

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            Album album = new Album("Album " + id);

            return View(album);
        }
    }
}