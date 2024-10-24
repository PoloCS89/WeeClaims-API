using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeeClaimsService.Api.Models
{
    public class Compania
    {
        public int Id { get; set; }
        public string NombreCompania { get; set; }
        public string NombrePersonaContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
    }
}