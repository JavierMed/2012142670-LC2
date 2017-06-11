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
using _2012142670_ENT.IRepositories;
using _2012142670_ENT.EntitiesDTO;
using _2012142670_PER;
using AutoMapper;

namespace _2012142670_WebApi.Controllers
{
    public class ClienteController : ApiController
    {
        //private _2012142670DBContext db = new _2012142670DBContext();
        private readonly IUnityOfWork _unityOfWrok;
        public ClienteController(IUnityOfWork unityOfWrok)
        {
            _unityOfWrok = unityOfWrok;
        }

        // GET api/GenresApi
        [HttpGet]
        public IHttpActionResult Get()
        {
            //La capa de persistencia no debe ser modificada, porque es única para todo canal de atencion de la aplicacion
            //por lo tanto, a nivel de controlador se debe de hacer las modificaciones.
            var Clientes = _unityOfWrok.Cliente.GetAll();

            if (Clientes == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            var ClienteDTO = new List<ClienteDTO>();

            foreach (var cliente in Clientes)
                ClienteDTO.Add(Mapper.Map<Cliente, ClienteDTO>(cliente));

            return Ok(ClienteDTO);
        }


        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var cliente = _unityOfWrok.Cliente.Get(id);

            if (cliente == null)
                return NotFound();

            return Ok(Mapper.Map<Cliente, ClienteDTO>(cliente));
        }

        // PUT: api/GenresApi/5

        //	return StatusCode(HttpStatusCode.NoContent);
        //}
        [HttpPut]
        public IHttpActionResult Update(int id, ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clienteInPersistence = _unityOfWrok.Cliente.Get(id);
            if (clienteInPersistence == null)
                return NotFound();

            Mapper.Map<ClienteDTO, Cliente>(clienteDTO, clienteInPersistence);

            _unityOfWrok.SaveChange();

            return Ok(clienteDTO);
        }


        // POST: api/GenresApi
        
        [HttpPost]
        public IHttpActionResult Create(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cliente = Mapper.Map<ClienteDTO, Cliente>(clienteDTO);

            _unityOfWrok.Cliente.Add(cliente);
            _unityOfWrok.SaveChange();

            clienteDTO.ClienteId = cliente.ClienteId;

            return Created(new Uri(Request.RequestUri + "/" + cliente.ClienteId), clienteDTO);
        }

        // DELETE: api/GenresApi/5
       
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var clienteInDataBase = _unityOfWrok.Cliente.Get(id);
            if (clienteInDataBase == null)
                return NotFound();

            _unityOfWrok.Cliente.Delete(clienteInDataBase);
            _unityOfWrok.SaveChange();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unityOfWrok.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}