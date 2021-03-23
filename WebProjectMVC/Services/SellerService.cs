using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectMVC.Data;
using WebProjectMVC.Models;

namespace WebProjectMVC.Services
{
    public class SellerService
    {
        private readonly WebProjectMVCContext _context;

        public SellerService(WebProjectMVCContext context)
        {
            _context = context;
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
