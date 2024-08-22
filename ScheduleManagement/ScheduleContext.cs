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
        public DbSet<ScheduleEvent> Events { get; set; }
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

// Changed every instance of "ScheduleTask" 
// to "ScheduleEvent", completely recreated 
// database and migrations to confirm change, 
// made it so events display in an organized 
// fashion in the ListView, added several 
// labels on each form to help with navigation, 
// changed some text to be capitalized in 
// existing buttons. 