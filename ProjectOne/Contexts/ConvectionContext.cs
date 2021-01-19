using Microsoft.EntityFrameworkCore;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Contexts
{
    public class ConvectionContext:DbContext
    {
        public ConvectionContext(DbContextOptions options):base(options)
        {
       
        }
        public DbSet<Vendor> vendors { get; set; }
       
        public DbSet<Tag> Tags { get; set; }

    }
}
