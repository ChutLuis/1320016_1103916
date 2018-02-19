using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_1103916_1320016.Models;

namespace Laboratorio1_1103916_1320016.Controllers
{
    public class HomeController : Controller
    {
        List<PlayersModel> Jugadores = new List<PlayersModel>();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CargaCsv()
        {
            return View(new List<PlayersModel>());
        }

        [HttpPost]
        public ActionResult CargaCsv(HttpPostedFileBase postedFile)
        {
            List< PlayersModel> Players = new List<PlayersModel>();

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

                string CsvData = System.IO.File.ReadAllText(FilePath);
                int cont = 0;

                foreach (string row in CsvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        if (cont == 0)
                        {
                            cont++;
                        }
                        else
                        {
                            Players.Add(new PlayersModel
                            {
                                Equipo = row.Split(',')[0],
                                Apellido = row.Split(',')[1],
                                Nombre = row.Split(',')[2],
                                Posición = row.Split(',')[3],
                                SalarioBase = Double.Parse(row.Split(',')[4]),
                                Compensación = Double.Parse(row.Split(',')[5]),
                            });
                        }
                    }
                }
            }
            Jugadores = Players;
            return View(Players);
        }

        public ActionResult TipoLista()
        {
            return View();
        }

        public ActionResult OrdenarLista()
        {
            Jugadores.Sort();
            return View(Jugadores);
        }

        public ActionResult Manual()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Manual([Bind(Include = "Equipo,Apellido,Nombre,Posición,SalarioBase,Compensacion")]PlayersModel jugador)
        {
            if (ModelState.IsValid)
            {
                Jugadores.Add(jugador);
                return RedirectToAction("TablaManual");
            }
            return View(jugador);
        }

        public ActionResult TablaManual()
        {
            return View(new List<PlayersModel>());
        }
    }
}