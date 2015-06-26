using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;
using MusicStore.Models.Repositories;

namespace MusicStore.Controllers
{
    public class ArtistsController : Controller
    {
        readonly ArtistRepository _repository = new ArtistRepository();

        public ActionResult Details(int id)
        {
            var artist = _repository.Get(id);

            if (artist == null)
            {
                return HttpNotFound();
            }

            return View(artist);
        }

        // GET: Artists
        public ActionResult Index()
        {
            return View(_repository.GetSoloArtists().ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(artist);
                _repository.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}