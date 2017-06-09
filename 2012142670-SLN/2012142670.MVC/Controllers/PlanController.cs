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
    public class PlanController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;

        public PlanController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: Plan
        public ActionResult Index()
        {
            //var plan = db.Plan.Include(p => p.Evaluacion);
            return View(_UnityOfWork.Plan.GetAll());
        }

        // GET: Plan/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plan.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // GET: Plan/Create
        public ActionResult Create()
        {
            //ViewBag.EvaluacionId = new SelectList(db.Evaluacion, "EvaluacionId", "EvaluacionId");
            return View();
        }

        // POST: Plan/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlanId,NombrePlan,TipoPlan")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Plan.Add(plan);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

            //ViewBag.EvaluacionId = new SelectList(db.Evaluacion, "EvaluacionId", "EvaluacionId", plan.EvaluacionId);
            return View(plan);
        }

        // GET: Plan/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plan.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            //ViewBag.EvaluacionId = new SelectList(db.Evaluacion, "EvaluacionId", "EvaluacionId", plan.EvaluacionId);
            return View(plan);
        }

        // POST: Plan/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlanId,NombrePlan,TipoPlan")] Plan plan)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(plan);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
            //ViewBag.EvaluacionId = new SelectList(db.Evaluacion, "EvaluacionId", "EvaluacionId", plan.EvaluacionId);
            return View(plan);
        }

        // GET: Plan/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plan plan = _UnityOfWork.Plan.Get(id);
            if (plan == null)
            {
                return HttpNotFound();
            }
            return View(plan);
        }

        // POST: Plan/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plan plan = _UnityOfWork.Plan.Get(id);
            _UnityOfWork.Plan.Delete(plan);
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
