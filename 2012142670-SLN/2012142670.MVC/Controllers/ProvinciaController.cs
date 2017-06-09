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
    public class ProvinciaController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public ProvinciaController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Provincia
        public ActionResult Index()
        {
            //var provincia = db.Provincia.Include(p => p.Departamento);
            return View(_UnityOfWork.Provincia.GetAll());
        }

        // GET: Provincia/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = _UnityOfWork.Provincia.Get(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // GET: Provincia/Create
        public ActionResult Create()
        {
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento");
            return View();
        }

        // POST: Provincia/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProvinciaId,nomProvincia,DepartamentoId")] Provincia provincia)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Provincia.Add(provincia);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", provincia.DepartamentoId);
            return View(provincia);
        }

        // GET: Provincia/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = _UnityOfWork.Provincia.Get(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", provincia.DepartamentoId);
            return View(provincia);
        }

        // POST: Provincia/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProvinciaId,nomProvincia,DepartamentoId")] Provincia provincia)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(provincia);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            //ViewBag.DepartamentoId = new SelectList(db.Departamento, "DepartamentoId", "departamento", provincia.DepartamentoId);
            return View(provincia);
        }

        // GET: Provincia/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provincia provincia = _UnityOfWork.Provincia.Get(id);
            if (provincia == null)
            {
                return HttpNotFound();
            }
            return View(provincia);
        }

        // POST: Provincia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Provincia provincia = _UnityOfWork.Provincia.Get(id);
            _UnityOfWork.Provincia.Delete(provincia);
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
