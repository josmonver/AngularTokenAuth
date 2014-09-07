using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularTokenAuth.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext() :
            base("AppDbContext")
        {

        }
    }
}
