using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SA120974.Models;

namespace SA120974.Controllers
{
    [Authorize(Roles = "Administrador,Cliente")]
    public class IncidentesController : Controller
    {
        private Asturias db = new Asturias();

        // GET: Incidentes
        public ActionResult Index()
        {
            return View(db.incidentes.ToList());
        }

        // GET: Incidentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incidente incidente = db.incidentes.Find(id);
            if (incidente == null)
            {
                return HttpNotFound();
            }
            return View(incidente);
        }

        // GET: Incidentes/Create
        [Authorize(Roles = "Administrador")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Incidentes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,imagen,lugar,descripcion")] Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase imagen = Request.Files[0];
                    using (var ms = new System.IO.MemoryStream())
                    {
                        imagen.InputStream.CopyTo(ms);
                        incidente.imagen = ms.ToArray();
                    }
                    db.incidentes.Add(incidente);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(incidente);
        }

        // GET: Incidentes/Edit/5
        [Authorize(Roles = "Administrador")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incidente incidente = db.incidentes.Find(id);
            if (incidente == null)
            {
                return HttpNotFound();
            }
            return View(incidente);
        }

        // POST: Incidentes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Administrador")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,imagen,lugar,descripcion")] Incidente incidente)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFileBase imagen = Request.Files[0];
                    using (var ms = new System.IO.MemoryStream())
                    {
                        imagen.InputStream.CopyTo(ms);
                        incidente.imagen = ms.ToArray();
                    }
                    db.Entry(incidente).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(incidente);
        }

        // GET: Incidentes/Delete/5
        [Authorize(Roles = "Administrador")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Incidente incidente = db.incidentes.Find(id);
            if (incidente == null)
            {
                return HttpNotFound();
            }
            return View(incidente);
        }

        // POST: Incidentes/Delete/5
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Incidente incidente = db.incidentes.Find(id);
            db.incidentes.Remove(incidente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrador")]
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
