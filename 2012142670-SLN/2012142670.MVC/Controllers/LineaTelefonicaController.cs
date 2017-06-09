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
    public class LineaTelefonicaController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public LineaTelefonicaController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: LineaTelefonica
        public ActionResult Index()
        {
            return View(_UnityOfWork.LineaTelefonica.GetAll());
        }

        // GET: LineaTelefonica/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineaTelefonica/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LineaTelefonicaId,NumeroLinea,TipoLinea")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.LineaTelefonica.Add(lineaTelefonica);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonica/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LineaTelefonicaId,NumeroLinea,TipoLinea")] LineaTelefonica lineaTelefonica)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(lineaTelefonica);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            return View(lineaTelefonica);
        }

        // GET: LineaTelefonica/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            if (lineaTelefonica == null)
            {
                return HttpNotFound();
            }
            return View(lineaTelefonica);
        }

        // POST: LineaTelefonica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LineaTelefonica lineaTelefonica = _UnityOfWork.LineaTelefonica.Get(id);
            _UnityOfWork.LineaTelefonica.Delete(lineaTelefonica);
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
