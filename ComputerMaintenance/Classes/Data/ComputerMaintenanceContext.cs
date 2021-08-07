using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


// ** TO DO ** 
// - Set up Entity Framework Context for LocalDb

namespace ComputerMaintenance.Classes.Data
{
    class ComputerMaintenanceContext : DbContext
    {
        public ComputerMaintenanceContext(DbContextOptions<ComputerMaintenanceContext> options) : base(options)
        {
        }
    }
}
