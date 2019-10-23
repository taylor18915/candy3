using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candy3.Data;

namespace Candy3.Pages.Ord
{
    public class IndexModel : PageModel
    {
        private readonly Candy3.Data.ApplicationDbContext _context;

        public IndexModel(Candy3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Orderscs> Orderscs { get;set; }

        public async Task OnGetAsync()
        {    var can= from m  in  _context.Candy select m;
            can = can.Where(s => s.Ctype.Contains("hershey"));
             
        }
    }
}
