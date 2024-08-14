using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScheduleManagement
{
    internal class ScheduleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Connection String
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WorkScheduleReneIsaac;Trusted_Connection=True;");
        }

        // Track Database Objects
        public DbSet<ScheduleTask> Tasks { get; set; }
    }
}

// Temporary developer log of commits for
// keeping track, can be ignored

// Installed required EF Core packages for
// database management, created schedule
// database context, created basic ScheduleTask
// object, created database with code first
// migrations, prepared basic but unfinished
// CRUD functionality for the Display and Add
// buttons, verified that the Add form functions.