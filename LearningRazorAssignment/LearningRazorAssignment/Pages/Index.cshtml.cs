using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LearningRazorAssignment;

namespace LearningRazorAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LearningRazorAssignment.online_storeContext _context;

        public IndexModel(LearningRazorAssignment.online_storeContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.Gender).ToListAsync();
        }
    }
}
