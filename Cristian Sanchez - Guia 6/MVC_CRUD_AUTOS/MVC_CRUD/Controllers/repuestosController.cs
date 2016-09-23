using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD.Models;

namespace MVC_CRUD.Controllers
{
    public class repuestosController : Controller
    {
        private AutosModelo db = new AutosModelo();

        // GET: repuestoes
        public ActionResult Index()
        {
            var repuestos = db.repuestos.Include(r => r.modelo);
            return View(repuestos.ToList());
        }

        // GET: repuestoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repuesto repuesto = db.repuestos.Find(id);
            if (repuesto == null)
            {
                return HttpNotFound();
            }
            return View(repuesto);
        }

        // GET: repuestoes/Create
        public ActionResult Create()
        {
            ViewBag.id_modelos = new SelectList(db.modelos, "id_modelos", "modelo1");
            return View();
        }

        // POST: repuestoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_rep,nombre,precio,descuento,id_modelos")] repuesto repuesto)
        {
            if (ModelState.IsValid)
            {
                db.repuestos.Add(repuesto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_modelos = new SelectList(db.modelos, "id_modelos", "modelo1", repuesto.id_modelos);
            return View(repuesto);
        }

        // GET: repuestoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repuesto repuesto = db.repuestos.Find(id);
            if (repuesto == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_modelos = new SelectList(db.modelos, "id_modelos", "modelo1", repuesto.id_modelos);
            return View(repuesto);
        }

        // POST: repuestoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_rep,nombre,precio,descuento,id_modelos")] repuesto repuesto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(repuesto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_modelos = new SelectList(db.modelos, "id_modelos", "modelo1", repuesto.id_modelos);
            return View(repuesto);
        }

        // GET: repuestoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            repuesto repuesto = db.repuestos.Find(id);
            if (repuesto == null)
            {
                return HttpNotFound();
            }
            return View(repuesto);
        }

        // POST: repuestoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repuesto repuesto = db.repuestos.Find(id);
            db.repuestos.Remove(repuesto);
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
