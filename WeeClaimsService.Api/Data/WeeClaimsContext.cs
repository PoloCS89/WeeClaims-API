using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeeClaimsService.Api.Models;

namespace WeeClaimsService.Api.Data
{
    public class WeeClaimsContext : DbContext
    {
        public WeeClaimsContext() : base("name=CommonConection") { }

        public DbSet<Compania> Compania { get; set; }
    }
}