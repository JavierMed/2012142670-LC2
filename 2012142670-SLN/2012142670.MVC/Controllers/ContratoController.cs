using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2012142670_ENT.Entities;
using _2012142670_ENT.IRepositories;
using _2012142670_PER;

namespace _2012142670.MVC.Controllers
{
    public class ContratoController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public ContratoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Contrato
        public ActionResult Index()
        {
          //var contrato = db.Contrato.Include(c => c.Venta);
            return View(_UnityOfWork.Contrato.GetAll());
        }

        // GET: Contrato/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // GET: Contrato/Create
        public ActionResult Create()
        {
          //ViewBag.VentaId = new SelectList(db.Venta, "VentaId", "VentaId");
            return View();
        }

        // POST: Contrato/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContratoId,FechaContrato,VentaId")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Contrato.Add(contrato);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

          //ViewBag.VentaId = new SelectList(db.Venta, "VentaId", "VentaId", contrato.VentaId);
            return View(contrato);
        }

        // GET: Contrato/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
          //ViewBag.VentaId = new SelectList(db.Venta, "VentaId", "VentaId", contrato.VentaId);
            return View(contrato);
        }

        // POST: Contrato/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContratoId,FechaContrato,VentaId")] Contrato contrato)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(contrato);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
          //ViewBag.VentaId = new SelectList(db.Venta, "VentaId", "VentaId", contrato.VentaId);
            return View(contrato);
        }

        // GET: Contrato/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            if (contrato == null)
            {
                return HttpNotFound();
            }
            return View(contrato);
        }

        // POST: Contrato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contrato contrato = _UnityOfWork.Contrato.Get(id);
            _UnityOfWork.Contrato.Delete(contrato);
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
