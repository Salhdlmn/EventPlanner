using AIEventPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AIEventPlanner.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Event> Events { get; set; }



    }
}