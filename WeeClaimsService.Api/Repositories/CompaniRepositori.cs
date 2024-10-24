using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WeeClaimsService.Api.Data;
using WeeClaimsService.Api.Models;

namespace WeeClaimsService.Api.Repositories
{
    public class CompaniRepositori : ICompaniRepositori
    {
        private readonly WeeClaimsContext _context;

        public CompaniRepositori(WeeClaimsContext context)
        {
            _context = context;
        }

        public void Agregar(Compania compania)
        {
            var sql = "EXEC sp_InsertarCompania @NombreCompania, @NombrePersonaContacto, @CorreoElectronico, @Telefono";

            var parameters = new[]
            {
                new SqlParameter("@NombreCompania", compania.NombreCompania),
                new SqlParameter("@NombrePersonaContacto", compania.NombrePersonaContacto),
                new SqlParameter("@CorreoElectronico", compania.CorreoElectronico),
                new SqlParameter("@Telefono", compania.Telefono)
            };

            _context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public void Actualizar(Compania compania)
        {
            var sql = "EXEC sp_ActualizarCompania @Id, @NombreCompania, @NombrePersonaContacto, @CorreoElectronico, @Telefono";

            var parameters = new[]
            {
                new SqlParameter("@Id", compania.Id),
                new SqlParameter("@NombreCompania", compania.NombreCompania),
                new SqlParameter("@NombrePersonaContacto", compania.NombrePersonaContacto),
                new SqlParameter("@CorreoElectronico", compania.CorreoElectronico),
                new SqlParameter("@Telefono", compania.Telefono)
            };

            _context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public void Eliminar(int id)
        {
            var sql = "EXEC sp_EliminarCompania @Id";
            var parameter = new SqlParameter("@Id", id);
            _context.Database.ExecuteSqlCommand(sql, parameter);
        }

        public Compania ObtenerPorId(int id)
        {
            var sql = "EXEC sp_ConsultarCompaniaPorId @Id";
            var parameter = new SqlParameter("@Id", id);

            return _context.Database.SqlQuery<Compania>(sql, parameter).FirstOrDefault();
        }

        public IEnumerable<Compania> ObtenerTodo()
        {
            var sql = "EXEC sp_ConsultarCompanias";
            return _context.Database.SqlQuery<Compania>(sql).ToList();
        }
    }
}