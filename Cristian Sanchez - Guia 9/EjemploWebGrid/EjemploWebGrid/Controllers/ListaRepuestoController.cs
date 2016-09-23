using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EjemploWebGrid.Models;

namespace EjemploWebGrid.Controllers
{
    public class ListaRepuestoController : Controller
    {
        // GET: ListaRepuesto
        public ActionResult Index()
        {
            autos DB = new autos();
            return View(DB.repuestos.ToList());
        }
    }
}