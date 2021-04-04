using Microsoft.EntityFrameworkCore;
using Pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro.Data
{
    public class MvcCertificationContext: DbContext
    {
        public MvcCertificationContext(DbContextOptions<MvcCertificationContext> options)
            : base(options)
        {
        }

        public DbSet<Certification> Certification { get; set; }
    }
}
