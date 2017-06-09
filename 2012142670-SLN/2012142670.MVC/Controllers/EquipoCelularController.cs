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
    public class EquipoCelularController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();
        //dsadasddasduihdhihdhuiashduihsiudhiasdhe32wrwwwsdfsdgdfgsfgsklsf♀{rq═N9╗6ÿS5♠euiguierghuyerghue
        private readonly IUnityOfWork _UnityOfWork;
        public EquipoCelularController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: EquipoCelular
        public ActionResult Index()
        {
            return View(_UnityOfWork.EquipoCelular.GetAll());
        }

        // GET: EquipoCelular/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelular.Get(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelular/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquipoCelular/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoCelularId,Modelo")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.EquipoCelular.Add(equipoCelular);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            return View(equipoCelular);
        }

        // GET: EquipoCelular/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelular.Get(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelular/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoCelularId,Modelo")] EquipoCelular equipoCelular)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(equipoCelular);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            return View(equipoCelular);
        }

        // GET: EquipoCelular/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelular.Get(id);
            if (equipoCelular == null)
            {
                return HttpNotFound();
            }
            return View(equipoCelular);
        }

        // POST: EquipoCelular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipoCelular equipoCelular = _UnityOfWork.EquipoCelular.Get(id);
            _UnityOfWork.EquipoCelular.Delete(equipoCelular);
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
