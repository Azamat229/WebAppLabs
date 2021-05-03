using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Azamat_id_999.DAL.Data;
using Azamat_id_999.DAL.Entities;

namespace Azamat_id_999.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Azamat_id_999.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Azamat_id_999.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; }

        public async Task OnGetAsync()
        {
            Dish = await _context.Dishes
                .Include(d => d.DishGroup).ToListAsync();
        }
    }
}
