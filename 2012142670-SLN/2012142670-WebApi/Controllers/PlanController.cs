using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using _2012142670_ENT.Entities;
using _2012142670_PER;

namespace _2012142670_WebApi.Controllers
{
    public class PlanController : ApiController
    {
        private _2012142670DBContext db = new _2012142670DBContext();

        // GET: api/Plan
        public IQueryable<Plan> GetPlan()
        {
            return db.Plan;
        }

        // GET: api/Plan/5
        [ResponseType(typeof(Plan))]
        public IHttpActionResult GetPlan(int id)
        {
            Plan plan = db.Plan.Find(id);
            if (plan == null)
            {
                return NotFound();
            }

            return Ok(plan);
        }

        // PUT: api/Plan/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlan(int id, Plan plan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != plan.PlanId)
            {
                return BadRequest();
            }

            db.Entry(plan).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Plan
        [ResponseType(typeof(Plan))]
        public IHttpActionResult PostPlan(Plan plan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Plan.Add(plan);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = plan.PlanId }, plan);
        }

        // DELETE: api/Plan/5
        [ResponseType(typeof(Plan))]
        public IHttpActionResult DeletePlan(int id)
        {
            Plan plan = db.Plan.Find(id);
            if (plan == null)
            {
                return NotFound();
            }

            db.Plan.Remove(plan);
            db.SaveChanges();

            return Ok(plan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanExists(int id)
        {
            return db.Plan.Count(e => e.PlanId == id) > 0;
        }
    }
}