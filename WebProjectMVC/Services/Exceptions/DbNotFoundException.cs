using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProjectMVC.Services.Exceptions
{
    public class DbNotFoundException : ApplicationException
    {
        public DbNotFoundException(string message) : base(message)
        {

        }
    }
}
