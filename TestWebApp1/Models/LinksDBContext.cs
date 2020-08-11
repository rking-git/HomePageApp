using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HomePageApp.Models;
using System.Diagnostics.CodeAnalysis;

namespace HomePageApp.Models
{
    //Sets the DbContext derived class.
    public class LinksDbContext : DbContext
    {
        public LinksDbContext(DbContextOptions options)
    : base(options)
        {

        }


        public DbSet<Link> Links { get; set; }
    }
}
