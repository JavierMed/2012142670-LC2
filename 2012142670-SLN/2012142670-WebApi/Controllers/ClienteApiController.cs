using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using _2012142670_ENT.IRepositories;
using _2012142670_ENT.Entities;
using _2012142670_ENT.EntitiesDTO;
using AutoMapper;

namespace _2012142670_WebApi.Controllers
{
    public class ClienteApiController : ApiController
    {
        //private MovieStoreContext db = new MovieStoreContext();
        private readonly IUnityOfWork _UnityOfWork;

        public ClienteApiController()
        {

        }

        public ClienteApiController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        // GET: api/GenresApi
        //public IQueryable<Genre> GetGenres()
        //{
        //	return db.Genres;
        //}

        // GET api/GenresApi
        [HttpGet]
        public IHttpActionResult Get()
        {
            //La capa de persistencia no debe ser modificada, porque es única para todo canal de atencion de la aplicacion
            //por lo tanto, a nivel de controlador se debe de hacer las modificaciones.
            var Clientes = _UnityOfWork.Cliente.GetAll();

            if (Clientes == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var ClientesDTO = new List<ClienteDTO>();

            foreach (var cliente in Clientes)
                ClientesDTO.Add(Mapper.Map<Cliente, ClienteDTO>(cliente));

            return Ok(ClientesDTO);
        }

        // GET: api/GenresApi/5
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult GetGenre(int id)
        //{
        //	Genre genre = db.Genres.Find(id);
        //	if (genre == null)
        //	{
        //		return NotFound();
        //	}

        //	return Ok(genre);
        //}

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var cliente = _UnityOfWork.Cliente.Get(id);

            if (cliente == null)
                return NotFound();

            return Ok(Mapper.Map<Cliente, ClienteDTO>(cliente));
        }

        // PUT: api/GenresApi/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutGenre(int id, Genre genre)
        //{
        //	if (!ModelState.IsValid)
        //	{
        //		return BadRequest(ModelState);
        //	}

        //	if (id != genre.GenreId)
        //	{
        //		return BadRequest();
        //	}

        //	db.Entry(genre).State = EntityState.Modified;

        //	try
        //	{
        //		db.SaveChanges();
        //	}
        //	catch (DbUpdateConcurrencyException)
        //	{
        //		if (!GenreExists(id))
        //		{
        //			return NotFound();
        //		}
        //		else
        //		{
        //			throw;
        //		}
        //	}

        //	return StatusCode(HttpStatusCode.NoContent);
        //}
        [HttpPut]
        public IHttpActionResult Update(int id, ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clienteInPersistence = _UnityOfWork.Cliente.Get(id);
            if (clienteInPersistence == null)
                return NotFound();

            Mapper.Map<ClienteDTO, Cliente>(clienteDTO, clienteInPersistence);

            _UnityOfWork.SaveChange();

            return Ok(clienteDTO);
        }


        // POST: api/GenresApi
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult PostGenre(Genre genre)
        //{
        //	if (!ModelState.IsValid)
        //	{
        //		return BadRequest(ModelState);
        //	}

        //	db.Genres.Add(genre);
        //	db.SaveChanges();

        //	return CreatedAtRoute("DefaultApi", new { id = genre.GenreId }, genre);
        //}
        [HttpPost]
        public IHttpActionResult Create(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cliente = Mapper.Map<ClienteDTO, Cliente>(clienteDTO);

            _UnityOfWork.Cliente.Add(cliente);
            _UnityOfWork.SaveChange();

            clienteDTO.ClienteId = cliente.ClienteId;

            return Created(new Uri(Request.RequestUri + "/" + cliente.ClienteId), clienteDTO);
        }

        // DELETE: api/GenresApi/5
        //[ResponseType(typeof(Genre))]
        //public IHttpActionResult DeleteGenre(int id)
        //{
        //	Genre genre = db.Genres.Find(id);
        //	if (genre == null)
        //	{
        //		return NotFound();
        //	}

        //	db.Genres.Remove(genre);
        //	db.SaveChanges();

        //	return Ok(genre);
        //}
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clienteInDataBase = _UnityOfWork.Cliente.Get(id);
            if (clienteInDataBase == null)
                return NotFound();

            _UnityOfWork.Cliente.Delete(clienteInDataBase);
            _UnityOfWork.SaveChange();

            return Ok();
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