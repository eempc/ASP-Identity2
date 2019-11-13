using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebApplication2CountryContext : DbContext
    {
        public WebApplication2CountryContext (DbContextOptions<WebApplication2CountryContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Country> Country { get; set; }
    }
}
