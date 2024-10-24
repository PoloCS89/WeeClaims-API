
using AutoMapper;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Web.Http;
using WeeClaimsService.Api.Data;
using WeeClaimsService.Api.Models;
using WeeClaimsService.Api.Repositories;
using WeeClaimsService.Api.Services;

namespace WeeClaimsService.Api.Controllers
{
    [RoutePrefix("api/Compania")]
    public class CompaniaController : ApiController
    {
        private readonly ICompaniRepositori _companiaRepositori;
        private readonly IMapper _mapper;

        public CompaniaController(ICompaniRepositori companiaRepositori, IMapper mapper)
        {
            _companiaRepositori = companiaRepositori;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var companias = _companiaRepositori.ObtenerTodo();
            return Ok(companias);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var compania = _companiaRepositori.ObtenerPorId(id);
            if (compania == null)
                return NotFound();

            return Ok(compania);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] CompaniaViewModel companiaViewModel) 
        {
            var compania = _mapper.Map<Compania>(companiaViewModel);
            _companiaRepositori.Agregar(compania);
            return Ok();

            
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] CompaniaViewModel companiaViewModel) 
        {
            var existeComania = _companiaRepositori.ObtenerPorId(id);
            if (existeComania == null)
                return NotFound();

            var compania = _mapper.Map<Compania>(companiaViewModel);
            compania.Id = id;
            _companiaRepositori.Actualizar(compania);
            return Ok();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id) 
        {
            _companiaRepositori.Eliminar(id);
            return Ok();
        }
    }
}