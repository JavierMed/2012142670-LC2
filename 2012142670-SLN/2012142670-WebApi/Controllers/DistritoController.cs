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
    public class DistritoController : ApiController
    {
        private _2012142670DBContext db = new _2012142670DBContext();

        // GET: api/Distrito
        public IQueryable<Distrito> GetDistrito()
        {
            return db.Distrito;
        }

        // GET: api/Distrito/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult GetDistrito(int id)
        {
            Distrito distrito = db.Distrito.Find(id);
            if (distrito == null)
            {
                return NotFound();
            }

            return Ok(distrito);
        }

        // PUT: api/Distrito/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDistrito(int id, Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != distrito.DistritoId)
            {
                return BadRequest();
            }

            db.Entry(distrito).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DistritoExists(id))
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

        // POST: api/Distrito
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult PostDistrito(Distrito distrito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Distrito.Add(distrito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = distrito.DistritoId }, distrito);
        }

        // DELETE: api/Distrito/5
        [ResponseType(typeof(Distrito))]
        public IHttpActionResult DeleteDistrito(int id)
        {
            Distrito distrito = db.Distrito.Find(id);
            if (distrito == null)
            {
                return NotFound();
            }

            db.Distrito.Remove(distrito);
            db.SaveChanges();

            return Ok(distrito);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DistritoExists(int id)
        {
            return db.Distrito.Count(e => e.DistritoId == id) > 0;
        }
    }
}