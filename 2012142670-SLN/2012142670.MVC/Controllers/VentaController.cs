using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012142670_ENT.Entities;
using _2012142670_PER;
using _2012142670_ENT.IRepositories;

namespace _2012142670.MVC.Controllers
{
    public class VentaController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;

        public VentaController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Venta
        public ActionResult Index()
        {
            //var venta = db.Venta.Include(v => v.Contrato);
            return View(_UnityOfWork.Venta.GetAll());
        }

        // GET: Venta/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = _UnityOfWork.Venta.Get(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // GET: Venta/Create
        public ActionResult Create()
        {
            //ViewBag.ContratoId = new SelectList(db.Contrato, "ContratoId", "ContratoId");
            return View();
        }

        // POST: Venta/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VentaId,precio,ContratoId,codLineaTele,TipoPago")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Venta.Add(venta);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            //ViewBag.ContratoId = new SelectList(db.Contrato, "ContratoId", "ContratoId", venta.ContratoId);
            return View(venta);
        }

        // GET: Venta/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = _UnityOfWork.Venta.Get(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            //ViewBag.ContratoId = new SelectList(db.Contrato, "ContratoId", "ContratoId", venta.ContratoId);
            return View(venta);
        }

        // POST: Venta/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VentaId,precio,ContratoId,codLineaTele,TipoPago")] Venta venta)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(venta);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            //ViewBag.ContratoId = new SelectList(db.Contrato, "ContratoId", "ContratoId", venta.ContratoId);
            return View(venta);
        }

        // GET: Venta/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta venta = _UnityOfWork.Venta.Get(id);
            if (venta == null)
            {
                return HttpNotFound();
            }
            return View(venta);
        }

        // POST: Venta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Venta venta = _UnityOfWork.Venta.Get(id);
            _UnityOfWork.Venta.Delete(venta);
            _UnityOfWork.SaveChange();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
