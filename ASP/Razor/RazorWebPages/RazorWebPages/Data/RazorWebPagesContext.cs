using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorWebPages.Models;

namespace RazorWebPages.Data
{
    public class RazorWebPagesContext : DbContext
    {
        public RazorWebPagesContext (DbContextOptions<RazorWebPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorWebPages.Models.Movie> Movie { get; set; }
    }
}
