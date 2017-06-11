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
    public class CentroAtencionController : ApiController
    {
        private _2012142670DBContext db = new _2012142670DBContext();

        // GET: api/CentroAtencion
        public IQueryable<CentroAtencion> GetCentroAtencion()
        {
            return db.CentroAtencion;
        }

        // GET: api/CentroAtencion/5
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult GetCentroAtencion(int id)
        {
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            if (centroAtencion == null)
            {
                return NotFound();
            }

            return Ok(centroAtencion);
        }

        // PUT: api/CentroAtencion/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCentroAtencion(int id, CentroAtencion centroAtencion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != centroAtencion.CentroAtencionId)
            {
                return BadRequest();
            }

            db.Entry(centroAtencion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroAtencionExists(id))
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

        // POST: api/CentroAtencion
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult PostCentroAtencion(CentroAtencion centroAtencion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CentroAtencion.Add(centroAtencion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = centroAtencion.CentroAtencionId }, centroAtencion);
        }

        // DELETE: api/CentroAtencion/5
        [ResponseType(typeof(CentroAtencion))]
        public IHttpActionResult DeleteCentroAtencion(int id)
        {
            CentroAtencion centroAtencion = db.CentroAtencion.Find(id);
            if (centroAtencion == null)
            {
                return NotFound();
            }

            db.CentroAtencion.Remove(centroAtencion);
            db.SaveChanges();

            return Ok(centroAtencion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CentroAtencionExists(int id)
        {
            return db.CentroAtencion.Count(e => e.CentroAtencionId == id) > 0;
        }
    }
}