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

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
