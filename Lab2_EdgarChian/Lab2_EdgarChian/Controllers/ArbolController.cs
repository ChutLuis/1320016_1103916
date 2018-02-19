using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_EdgarChian.Models;
using Newtonsoft.Json;

namespace Lab2_EdgarChian.Controllers
{
    public class ArbolController : Controller
    {
        // GET: Arbol
        public ActionResult Index()
        {
            var path = @"C:\Users\ricar\Desktop\dataPaises.json";
            var contenido = System.IO.File.ReadAllText(path);
            var arbol = JsonConvert.DeserializeObject<Arbol>(contenido);

            var cadena = JsonConvert.SerializeObject(arbol);

            TempData["arbol"] = cadena; //Dato que se puede mandar del controlador a la vista
            return View();
        }

        // GET: Arbol/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Arbol/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arbol/Create
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

        // GET: Arbol/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Arbol/Edit/5
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

        // GET: Arbol/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Arbol/Delete/5
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
