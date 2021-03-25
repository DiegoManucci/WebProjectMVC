using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProjectMVC.Data;
using WebProjectMVC.Models;

namespace WebProjectMVC.Services
{
    public class DepartmentService
    {
        private readonly WebProjectMVCContext _context;

        public DepartmentService(WebProjectMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }

    }
}
