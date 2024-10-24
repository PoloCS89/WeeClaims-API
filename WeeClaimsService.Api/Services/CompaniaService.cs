using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;
using WeeClaimsService.Api.Models;
using WeeClaimsService.Api.Repositories;

namespace WeeClaimsService.Api.Services
{
    public class CompaniaService
    {
        private readonly ICompaniRepositori _companiaRepositori;

        public CompaniaService(ICompaniRepositori personRepositori)
        {
            _companiaRepositori = personRepositori;
        }

        public IEnumerable<Compania> ObtenerCompanias() 
        {
            return _companiaRepositori.ObtenerTodo();
        }

        public Compania ObtenerCompaniaPorId(int id) 
        {
            return _companiaRepositori.ObtenerPorId(id);
        }

        public void AgregarCompania(Compania compania) 
        {
            _companiaRepositori.Agregar(compania);
        }

        public void ActualizarCompania(Compania compania) 
        {
            _companiaRepositori.Actualizar(compania);
        }

        public void EliminarCompania(int id) 
        {
            var compania = _companiaRepositori.ObtenerPorId(id);
            if (compania != null) 
            {
                _companiaRepositori.Eliminar(id);
            }
        }
    }
}