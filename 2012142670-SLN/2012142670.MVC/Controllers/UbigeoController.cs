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
    public class UbigeoController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public UbigeoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Ubigeo
        public ActionResult Index()
        {
            //var ubigeo = db.Ubigeo.Include(u => u.Departamento);
            return View(_UnityOfWork.Ubigeo.GetAll());
        }

        // GET: Ubigeo/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeo ubigeo = _UnityOfWork.Ubigeo.Get(id);
            if (ubigeo == null)
            {
                return HttpNotFound();
            }
            return View(ubigeo);
        }

        // GET: Ubigeo/Create
        public ActionResult Create()
        {
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento");
            return View();
        }

        // POST: Ubigeo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UbigeoId,DepartamentoId")] Ubigeo ubigeo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Ubigeo.Add(ubigeo);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", ubigeo.DepartamentoId);
            return View(ubigeo);
        }

        // GET: Ubigeo/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeo ubigeo = _UnityOfWork.Ubigeo.Get(id);
            if (ubigeo == null)
            {
                return HttpNotFound();
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", ubigeo.DepartamentoId);
            return View(ubigeo);
        }

        // POST: Ubigeo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UbigeoId,DepartamentoId")] Ubigeo ubigeo)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(ubigeo);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", ubigeo.DepartamentoId);
            return View(ubigeo);
        }

        // GET: Ubigeo/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ubigeo ubigeo = _UnityOfWork.Ubigeo.Get(id);
            if (ubigeo == null)
            {
                return HttpNotFound();
            }
            return View(ubigeo);
        }

        // POST: Ubigeo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ubigeo ubigeo = _UnityOfWork.Ubigeo.Get(id);
            _UnityOfWork.Ubigeo.Delete(ubigeo);
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
