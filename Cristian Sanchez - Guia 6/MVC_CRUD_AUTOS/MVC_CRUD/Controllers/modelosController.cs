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
    public class modelosController : Controller
    {
        private AutosModelo db = new AutosModelo();

        // GET: modeloes
        public ActionResult Index()
        {
            var modelos = db.modelos.Include(m => m.marca);
            return View(modelos.ToList());
        }

        // GET: modeloes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            modelo modelo = db.modelos.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        // GET: modeloes/Create
        public ActionResult Create()
        {
            ViewBag.id_marca = new SelectList(db.marcas, "id_marca", "marca1");
            return View();
        }

        // POST: modeloes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_modelos,modelo1,asientos,combustible,precio,year_modelo,id_marca")] modelo modelo)
        {
            if (ModelState.IsValid)
            {
                db.modelos.Add(modelo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_marca = new SelectList(db.marcas, "id_marca", "marca1", modelo.id_marca);
            return View(modelo);
        }

        // GET: modeloes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            modelo modelo = db.modelos.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_marca = new SelectList(db.marcas, "id_marca", "marca1", modelo.id_marca);
            return View(modelo);
        }

        // POST: modeloes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_modelos,modelo1,asientos,combustible,precio,year_modelo,id_marca")] modelo modelo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modelo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_marca = new SelectList(db.marcas, "id_marca", "marca1", modelo.id_marca);
            return View(modelo);
        }

        // GET: modeloes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            modelo modelo = db.modelos.Find(id);
            if (modelo == null)
            {
                return HttpNotFound();
            }
            return View(modelo);
        }

        // POST: modeloes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            modelo modelo = db.modelos.Find(id);
            db.modelos.Remove(modelo);
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
