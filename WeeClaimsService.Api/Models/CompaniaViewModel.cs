using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeeClaimsService.Api.Models
{
    public class CompaniaViewModel
    {
        public string NombreCompania { get; set; }
        public string NombrePersonaContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}