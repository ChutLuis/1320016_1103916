using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4_1103916_1320016.Models;
using Newtonsoft.Json;

namespace Lab4_1103916_1320016.Controllers
{
    public class StickersPaniniController : Controller
    {
        public Dictionary<StickersPanini, Pais> dictionary = new Dictionary<StickersPanini, Pais>();
        private StickersPanini Album;

        public ActionResult CargaCsv()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CargaCsv(HttpPostedFileBase postedFile)
        {
            string FilePath = string.Empty;

            if (postedFile != null)
            {
                string path = Server.MapPath("~/Carga/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                FilePath = path + Path.GetFileName(postedFile.FileName);
                string Extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(FilePath);

                Album = JsonConvert.DeserializeObject<StickersPanini>(FilePath);

                dictionary = new Dictionary<StickersPanini, Pais>();
                dictionary.Add(Album,Album.pais);
            }
            var data = dictionary.Select(x => x.Value).ToList().ToString();

            TempData["diccionario"] = data;

            return View(TempData.ToString());
        }

        // GET: StickersPanini
        public ActionResult Index()
        {
            return View();
        }

        // GET: StickersPanini/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StickersPanini/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StickersPanini/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StickersPanini/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StickersPanini/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StickersPanini/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StickersPanini/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
