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
    public class CentroAtencionController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public CentroAtencionController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: CentroAtencion
        public ActionResult Index()
        {
            //r centroAtencion = db.CentroAtencion.Include(c => c.Ubigeo);
            return View(_UnityOfWork.CentroAtencion.GetAll());
        }

        // GET: CentroAtencion/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = _UnityOfWork.CentroAtencion.Get(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // GET: CentroAtencion/Create
        public ActionResult Create()
        {
            //ewBag.UbigeoId = new SelectList(db.Ubigeo, "UbigeoId", "UbigeoId");
            return View();
        }

        // POST: CentroAtencion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CentroAtencionId,NombreCentroAtencion,Direccion,Telefono,UbigeoId")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.CentroAtencion.Add(centroAtencion);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

          //ViewBag.UbigeoId = new SelectList(db.Ubigeo, "UbigeoId", "UbigeoId", centroAtencion.UbigeoId);
            return View(centroAtencion);
        }

        // GET: CentroAtencion/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = _UnityOfWork.CentroAtencion.Get(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
          //ViewBag.UbigeoId = new SelectList(db.Ubigeo, "UbigeoId", "UbigeoId", centroAtencion.UbigeoId);
            return View(centroAtencion);
        }

        // POST: CentroAtencion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CentroAtencionId,NombreCentroAtencion,Direccion,Telefono,UbigeoId")] CentroAtencion centroAtencion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(centroAtencion);
                _UnityOfWork.SaveChange();
          return RedirectToAction("Index");
            }
          //ViewBag.UbigeoId = new SelectList(db.Ubigeo, "UbigeoId", "UbigeoId", centroAtencion.UbigeoId);
            return View(centroAtencion);
        }

        // GET: CentroAtencion/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CentroAtencion centroAtencion = _UnityOfWork.CentroAtencion.Get(id);
            if (centroAtencion == null)
            {
                return HttpNotFound();
            }
            return View(centroAtencion);
        }

        // POST: CentroAtencion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CentroAtencion centroAtencion = _UnityOfWork.CentroAtencion.Get(id);
            _UnityOfWork.CentroAtencion.Delete(centroAtencion);
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
