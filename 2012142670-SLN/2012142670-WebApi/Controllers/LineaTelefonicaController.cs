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
    public class LineaTelefonicaController : ApiController
    {
        private _2012142670DBContext db = new _2012142670DBContext();

        // GET: api/LineaTelefonica
        public IQueryable<LineaTelefonica> GetLineaTelefonica()
        {
            return db.LineaTelefonica;
        }

        // GET: api/LineaTelefonica/5
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult GetLineaTelefonica(int id)
        {
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return NotFound();
            }

            return Ok(lineaTelefonica);
        }

        // PUT: api/LineaTelefonica/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLineaTelefonica(int id, LineaTelefonica lineaTelefonica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lineaTelefonica.LineaTelefonicaId)
            {
                return BadRequest();
            }

            db.Entry(lineaTelefonica).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaTelefonicaExists(id))
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

        // POST: api/LineaTelefonica
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult PostLineaTelefonica(LineaTelefonica lineaTelefonica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LineaTelefonica.Add(lineaTelefonica);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lineaTelefonica.LineaTelefonicaId }, lineaTelefonica);
        }

        // DELETE: api/LineaTelefonica/5
        [ResponseType(typeof(LineaTelefonica))]
        public IHttpActionResult DeleteLineaTelefonica(int id)
        {
            LineaTelefonica lineaTelefonica = db.LineaTelefonica.Find(id);
            if (lineaTelefonica == null)
            {
                return NotFound();
            }

            db.LineaTelefonica.Remove(lineaTelefonica);
            db.SaveChanges();

            return Ok(lineaTelefonica);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LineaTelefonicaExists(int id)
        {
            return db.LineaTelefonica.Count(e => e.LineaTelefonicaId == id) > 0;
        }
    }
}