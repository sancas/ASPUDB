using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CRUD_TIENDA.Models;

namespace MVC_CRUD_TIENDA.Controllers
{
    public class PedidosController : Controller
    {
        private TiendaModel db = new TiendaModel();

        // GET: Pedidos
        public ActionResult Index()
        {
            var pEDIDOS = db.PEDIDOS.Include(p => p.CLIENTE);
            return View(pEDIDOS.ToList());
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDIDO pEDIDO = db.PEDIDOS.Find(id);
            if (pEDIDO == null)
            {
                return HttpNotFound();
            }
            return View(pEDIDO);
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTES, "ID_CLIENTE", "NOMBRE");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PEDIDO,FECHACREACION,ID_CLIENTE")] PEDIDO pEDIDO)
        {
            if (ModelState.IsValid)
            {
                db.PEDIDOS.Add(pEDIDO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTES, "ID_CLIENTE", "NOMBRE", pEDIDO.ID_CLIENTE);
            return View(pEDIDO);
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDIDO pEDIDO = db.PEDIDOS.Find(id);
            if (pEDIDO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTES, "ID_CLIENTE", "NOMBRE", pEDIDO.ID_CLIENTE);
            return View(pEDIDO);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PEDIDO,FECHACREACION,ID_CLIENTE")] PEDIDO pEDIDO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pEDIDO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTE = new SelectList(db.CLIENTES, "ID_CLIENTE", "NOMBRE", pEDIDO.ID_CLIENTE);
            return View(pEDIDO);
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PEDIDO pEDIDO = db.PEDIDOS.Find(id);
            if (pEDIDO == null)
            {
                return HttpNotFound();
            }
            return View(pEDIDO);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PEDIDO pEDIDO = db.PEDIDOS.Find(id);
            db.PEDIDOS.Remove(pEDIDO);
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
