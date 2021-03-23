using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProjectMVC.Models;

namespace WebProjectMVC.Data
{
    public class WebProjectMVCContext : DbContext
    {
        public WebProjectMVCContext (DbContextOptions<WebProjectMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
