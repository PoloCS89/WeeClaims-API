using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeeClaimsService.Api.Models;

namespace WeeClaimsService.Api.Repositories
{
    public interface ICompaniRepositori
    {
        void Agregar(Compania compania);
        void Actualizar(Compania compania);
        void Eliminar(int id);
        Compania ObtenerPorId(int id);
        IEnumerable<Compania> ObtenerTodo();
    }
}
