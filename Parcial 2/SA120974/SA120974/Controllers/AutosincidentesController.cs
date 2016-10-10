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
    [Authorize(Roles = "Administrador")]
    public class AutosincidentesController : Controller
    {
        private Asturias db = new Asturias();

        // GET: Autosincidentes
        public ActionResult Index()
        {
            var autosincidentes = db.autosincidentes.Include(a => a.auto).Include(a => a.incidente);
            return View(autosincidentes.ToList());
        }

        // GET: Autosincidentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autosincidente autosincidente = db.autosincidentes.Find(id);
            if (autosincidente == null)
            {
                return HttpNotFound();
            }
            return View(autosincidente);
        }

        // GET: Autosincidentes/Create
        public ActionResult Create()
        {
            ViewBag.idauto = new SelectList(db.autos, "id", "placa");
            ViewBag.idincidente = new SelectList(db.incidentes, "id", "id");
            return View();
        }

        // POST: Autosincidentes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idauto,idincidente")] Autosincidente autosincidente)
        {
            if (ModelState.IsValid)
            {
                db.autosincidentes.Add(autosincidente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idauto = new SelectList(db.autos, "id", "placa", autosincidente.idauto);
            ViewBag.idincidente = new SelectList(db.incidentes, "id", "id", autosincidente.idincidente);
            return View(autosincidente);
        }

        // GET: Autosincidentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autosincidente autosincidente = db.autosincidentes.Find(id);
            if (autosincidente == null)
            {
                return HttpNotFound();
            }
            ViewBag.idauto = new SelectList(db.autos, "id", "placa", autosincidente.idauto);
            ViewBag.idincidente = new SelectList(db.incidentes, "id", "id", autosincidente.idincidente);
            return View(autosincidente);
        }

        // POST: Autosincidentes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idauto,idincidente")] Autosincidente autosincidente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autosincidente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idauto = new SelectList(db.autos, "id", "placa", autosincidente.idauto);
            ViewBag.idincidente = new SelectList(db.incidentes, "id", "id", autosincidente.idincidente);
            return View(autosincidente);
        }

        // GET: Autosincidentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autosincidente autosincidente = db.autosincidentes.Find(id);
            if (autosincidente == null)
            {
                return HttpNotFound();
            }
            return View(autosincidente);
        }

        // POST: Autosincidentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autosincidente autosincidente = db.autosincidentes.Find(id);
            db.autosincidentes.Remove(autosincidente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
