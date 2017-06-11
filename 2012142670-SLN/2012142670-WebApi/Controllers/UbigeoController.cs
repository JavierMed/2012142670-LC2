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
    public class UbigeoController : ApiController
    {
        private _2012142670DBContext db = new _2012142670DBContext();

        // GET: api/Ubigeo
        public IQueryable<Ubigeo> GetUbigeo()
        {
            return db.Ubigeo;
        }

        // GET: api/Ubigeo/5
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult GetUbigeo(int id)
        {
            Ubigeo ubigeo = db.Ubigeo.Find(id);
            if (ubigeo == null)
            {
                return NotFound();
            }

            return Ok(ubigeo);
        }

        // PUT: api/Ubigeo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUbigeo(int id, Ubigeo ubigeo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ubigeo.UbigeoId)
            {
                return BadRequest();
            }

            db.Entry(ubigeo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UbigeoExists(id))
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

        // POST: api/Ubigeo
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult PostUbigeo(Ubigeo ubigeo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ubigeo.Add(ubigeo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ubigeo.UbigeoId }, ubigeo);
        }

        // DELETE: api/Ubigeo/5
        [ResponseType(typeof(Ubigeo))]
        public IHttpActionResult DeleteUbigeo(int id)
        {
            Ubigeo ubigeo = db.Ubigeo.Find(id);
            if (ubigeo == null)
            {
                return NotFound();
            }

            db.Ubigeo.Remove(ubigeo);
            db.SaveChanges();

            return Ok(ubigeo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UbigeoExists(int id)
        {
            return db.Ubigeo.Count(e => e.UbigeoId == id) > 0;
        }
    }
}