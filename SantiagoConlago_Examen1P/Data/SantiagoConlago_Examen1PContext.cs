using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SantiagoConlago_Examen1P.Models;

namespace SantiagoConlago_Examen1P.Data
{
    public class SantiagoConlago_Examen1PContext : DbContext
    {
        public SantiagoConlago_Examen1PContext (DbContextOptions<SantiagoConlago_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<SantiagoConlago_Examen1P.Models.SantiagoConlago_model> SantiagoConlago_model { get; set; } = default!;
    }
}
