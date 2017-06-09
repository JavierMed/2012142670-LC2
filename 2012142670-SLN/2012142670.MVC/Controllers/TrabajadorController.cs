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
    public class TrabajadorController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;

        public TrabajadorController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Trabajador
        public ActionResult Index()
        {
            return View(_UnityOfWork.Trabajador.GetAll());
        }

        // GET: Trabajador/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // GET: Trabajador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabajador/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TrabajadorId,NombreTrabajador,TipoTrabajador")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Trabajador.Add(trabajador);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            return View(trabajador);
        }

        // GET: Trabajador/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // POST: Trabajador/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TrabajadorId,NombreTrabajador,TipoTrabajador")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(trabajador);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            return View(trabajador);
        }

        // GET: Trabajador/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            if (trabajador == null)
            {
                return HttpNotFound();
            }
            return View(trabajador);
        }

        // POST: Trabajador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trabajador trabajador = _UnityOfWork.Trabajador.Get(id);
            _UnityOfWork.Trabajador.Delete(trabajador);
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
