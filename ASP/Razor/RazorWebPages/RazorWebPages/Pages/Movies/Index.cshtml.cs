using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebPages.Data;
using RazorWebPages.Models;

namespace RazorWebPages
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebPages.Data.RazorWebPagesContext _context;

        public IndexModel(RazorWebPages.Data.RazorWebPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
