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
    public class DistritoController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public DistritoController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Distrito
        public ActionResult Index()
        {
            //var distrito = db.Distrito.Include(d => d.Provincia);
            return View(_UnityOfWork.Distrito.GetAll());
        }

        // GET: Distrito/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _UnityOfWork.Distrito.Get(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // GET: Distrito/Create
        public ActionResult Create()
        {
            //ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "nomProvincia");
            return View();
        }

        // POST: Distrito/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DistritoId,nomDistrito,ProvinciaId")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Distrito.Add(distrito);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            //ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "nomProvincia", distrito.ProvinciaId);
            return View(distrito);
        }

        // GET: Distrito/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _UnityOfWork.Distrito.Get(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            //ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "nomProvincia", distrito.ProvinciaId);
            return View(distrito);
        }

        // POST: Distrito/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DistritoId,nomDistrito,ProvinciaId")] Distrito distrito)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(distrito);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            //ViewBag.ProvinciaId = new SelectList(db.Provincia, "ProvinciaId", "nomProvincia", distrito.ProvinciaId);
            return View(distrito);
        }

        // GET: Distrito/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Distrito distrito = _UnityOfWork.Distrito.Get(id);
            if (distrito == null)
            {
                return HttpNotFound();
            }
            return View(distrito);
        }

        // POST: Distrito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Distrito distrito = _UnityOfWork.Distrito.Get(id);
            _UnityOfWork.Distrito.Delete(distrito);
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
