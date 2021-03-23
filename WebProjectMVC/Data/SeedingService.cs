using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectMVC.Models;
using WebProjectMVC.Models.Enums;

namespace WebProjectMVC.Data
{
    public class SeedingService
    {
        private WebProjectMVCContext _context;

        public SeedingService(WebProjectMVCContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                //return; //DB has been seeded
            }

            Department department1 = new Department(1, "Computers");
            Department department2 = new Department(2, "Books");
            Department department3 = new Department(3, "Eletronics");
            Department department4 = new Department(4, "Clothes");

            Seller seller1 = new Seller(1, "Carlos", "carlos@gmail.com", 1500.0, new DateTime(1995, 6, 22), department1);
            Seller seller2 = new Seller(2, "Diego", "diego@gmail.com", 1500.0, new DateTime(1992, 3, 7), department2);

            SalesRecord salesRecord1 = new SalesRecord(1, new DateTime(2021, 3, 23), 10000.0, SaleStatus.Billed, seller1);
            SalesRecord salesRecord2 = new SalesRecord(2, new DateTime(2021, 3, 22), 12000.0, SaleStatus.Billed, seller2);

            _context.Department.AddRange(department1, department2, department3, department4);
            _context.Seller.AddRange(seller1, seller2);
            _context.SalesRecord.AddRange(salesRecord1, salesRecord2);

            _context.SaveChanges();
        }
    }
}
