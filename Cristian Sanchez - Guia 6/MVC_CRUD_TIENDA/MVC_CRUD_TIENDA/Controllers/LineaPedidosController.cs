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
    public class LineaPedidosController : Controller
    {
        private TiendaModel db = new TiendaModel();

        // GET: LineaPedidos
        public ActionResult Index()
        {
            var lINEAPEDIDOS = db.LINEAPEDIDOS.Include(l => l.PEDIDO).Include(l => l.PRODUCTO);
            return View(lINEAPEDIDOS.ToList());
        }

        // GET: LineaPedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINEAPEDIDO lINEAPEDIDO = db.LINEAPEDIDOS.Find(id);
            if (lINEAPEDIDO == null)
            {
                return HttpNotFound();
            }
            return View(lINEAPEDIDO);
        }

        // GET: LineaPedidos/Create
        public ActionResult Create()
        {
            ViewBag.ID_PEDIDO = new SelectList(db.PEDIDOS, "ID_PEDIDO", "ID_PEDIDO");
            ViewBag.ID_PRODUCTO = new SelectList(db.PRODUCTOS, "ID_PRODUCTO", "NOMBRE");
            return View();
        }

        // POST: LineaPedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_LINEAPEDIDO,UNIDADES,ID_PEDIDO,ID_PRODUCTO")] LINEAPEDIDO lINEAPEDIDO)
        {
            if (ModelState.IsValid)
            {
                db.LINEAPEDIDOS.Add(lINEAPEDIDO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_PEDIDO = new SelectList(db.PEDIDOS, "ID_PEDIDO", "ID_PEDIDO", lINEAPEDIDO.ID_PEDIDO);
            ViewBag.ID_PRODUCTO = new SelectList(db.PRODUCTOS, "ID_PRODUCTO", "NOMBRE", lINEAPEDIDO.ID_PRODUCTO);
            return View(lINEAPEDIDO);
        }

        // GET: LineaPedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINEAPEDIDO lINEAPEDIDO = db.LINEAPEDIDOS.Find(id);
            if (lINEAPEDIDO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_PEDIDO = new SelectList(db.PEDIDOS, "ID_PEDIDO", "ID_PEDIDO", lINEAPEDIDO.ID_PEDIDO);
            ViewBag.ID_PRODUCTO = new SelectList(db.PRODUCTOS, "ID_PRODUCTO", "NOMBRE", lINEAPEDIDO.ID_PRODUCTO);
            return View(lINEAPEDIDO);
        }

        // POST: LineaPedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_LINEAPEDIDO,UNIDADES,ID_PEDIDO,ID_PRODUCTO")] LINEAPEDIDO lINEAPEDIDO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lINEAPEDIDO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_PEDIDO = new SelectList(db.PEDIDOS, "ID_PEDIDO", "ID_PEDIDO", lINEAPEDIDO.ID_PEDIDO);
            ViewBag.ID_PRODUCTO = new SelectList(db.PRODUCTOS, "ID_PRODUCTO", "NOMBRE", lINEAPEDIDO.ID_PRODUCTO);
            return View(lINEAPEDIDO);
        }

        // GET: LineaPedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LINEAPEDIDO lINEAPEDIDO = db.LINEAPEDIDOS.Find(id);
            if (lINEAPEDIDO == null)
            {
                return HttpNotFound();
            }
            return View(lINEAPEDIDO);
        }

        // POST: LineaPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LINEAPEDIDO lINEAPEDIDO = db.LINEAPEDIDOS.Find(id);
            db.LINEAPEDIDOS.Remove(lINEAPEDIDO);
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
