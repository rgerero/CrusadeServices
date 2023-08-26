using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrusadeServices.Models;

namespace CrusadeServices.Data
{
    public class CrusadeServicesContext : DbContext
    {
        public CrusadeServicesContext (DbContextOptions<CrusadeServicesContext> options)
            : base(options)
        {
        }

        public DbSet<CrusadeServices.Models.Employee> Employee { get; set; } = default!;
    }
}
