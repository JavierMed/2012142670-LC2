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
    public class EvaluacionController : Controller
    {
        //private _2012142670DBContext db = new _2012142670DBContext();

        private readonly IUnityOfWork _UnityOfWork;
        public EvaluacionController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }


        // GET: Evaluacion
        public ActionResult Index()
        {
          //var evaluacion = db.Evaluacion.Include(e => e.CentroAtencion).Include(e => e.Cliente).Include(e => e.EquipoCelular).Include(e => e.LineaTelefonica).Include(e => e.Plan).Include(e => e.Trabajador);
            return View(_UnityOfWork.Evaluacion.GetAll());
        }

        // GET: Evaluacion/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacion.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // GET: Evaluacion/Create
        public ActionResult Create()
        {
         // ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "NombreCentroAtencion");
         // ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteId", "Nombre");
         // ViewBag.EquipoCelularId = new SelectList(db.EquipoCelular, "EquipoCelularId", "Modelo");
         // ViewBag.LineaTelefonicaId = new SelectList(db.LineaTelefonica, "LineaTelefonicaId", "LineaTelefonicaId");
         // ViewBag.PlanId = new SelectList(db.Plan, "PlanId", "NombrePlan");
         // ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTrabajador");
            return View();
        }

        // POST: Evaluacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluacionId,TrabajadorId,EstadoEvaluacion,TipoEvaluacion,ClienteId,PlanId,CentroAtencionId,LineaTelefonicaId,EquipoCelularId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.Evaluacion.Add(evaluacion);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }

          //ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "NombreCentroAtencion", evaluacion.CentroAtencionId);
          //ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteId", "Nombre", evaluacion.ClienteId);
          //ViewBag.EquipoCelularId = new SelectList(db.EquipoCelular, "EquipoCelularId", "Modelo", evaluacion.EquipoCelularId);
          //ViewBag.LineaTelefonicaId = new SelectList(db.LineaTelefonica, "LineaTelefonicaId", "LineaTelefonicaId", evaluacion.LineaTelefonicaId);
          //ViewBag.PlanId = new SelectList(db.Plan, "PlanId", "NombrePlan", evaluacion.PlanId);
          //ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTrabajador", evaluacion.TrabajadorId);
            return View(evaluacion);
        }

        // GET: Evaluacion/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacion.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
          //ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "NombreCentroAtencion", evaluacion.CentroAtencionId);
          //ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteId", "Nombre", evaluacion.ClienteId);
          //ViewBag.EquipoCelularId = new SelectList(db.EquipoCelular, "EquipoCelularId", "Modelo", evaluacion.EquipoCelularId);
          //ViewBag.LineaTelefonicaId = new SelectList(db.LineaTelefonica, "LineaTelefonicaId", "LineaTelefonicaId", evaluacion.LineaTelefonicaId);
          //ViewBag.PlanId = new SelectList(db.Plan, "PlanId", "NombrePlan", evaluacion.PlanId);
          //ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTrabajador", evaluacion.TrabajadorId);
            return View(evaluacion);
        }

        // POST: Evaluacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluacionId,TrabajadorId,EstadoEvaluacion,TipoEvaluacion,ClienteId,PlanId,CentroAtencionId,LineaTelefonicaId,EquipoCelularId")] Evaluacion evaluacion)
        {
            if (ModelState.IsValid)
            {
                _UnityOfWork.StateModified(evaluacion);
                _UnityOfWork.SaveChange();
                return RedirectToAction("Index");
            }
          //ViewBag.CentroAtencionId = new SelectList(db.CentroAtencion, "CentroAtencionId", "NombreCentroAtencion", evaluacion.CentroAtencionId);
          //ViewBag.ClienteId = new SelectList(db.Cliente, "ClienteId", "Nombre", evaluacion.ClienteId);
          //ViewBag.EquipoCelularId = new SelectList(db.EquipoCelular, "EquipoCelularId", "Modelo", evaluacion.EquipoCelularId);
          //ViewBag.LineaTelefonicaId = new SelectList(db.LineaTelefonica, "LineaTelefonicaId", "LineaTelefonicaId", evaluacion.LineaTelefonicaId);
          //ViewBag.PlanId = new SelectList(db.Plan, "PlanId", "NombrePlan", evaluacion.PlanId);
          //ViewBag.TrabajadorId = new SelectList(db.Trabajador, "TrabajadorId", "NombreTrabajador", evaluacion.TrabajadorId);
            return View(evaluacion);
        }

        // GET: Evaluacion/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evaluacion evaluacion = _UnityOfWork.Evaluacion.Get(id);
            if (evaluacion == null)
            {
                return HttpNotFound();
            }
            return View(evaluacion);
        }

        // POST: Evaluacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evaluacion evaluacion = _UnityOfWork.Evaluacion.Get(id);
            _UnityOfWork.Evaluacion.Delete(evaluacion);
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
