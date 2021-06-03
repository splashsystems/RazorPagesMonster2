using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster2.Data;
using RazorPagesMonster2.Models;

namespace RazorPagesMonster2.Pages.Monsters
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMonster2.Data.RazorPagesMonster2Context _context;

        public IndexModel(RazorPagesMonster2.Data.RazorPagesMonster2Context context)
        {
            _context = context;
        }

        public IList<Monster> Monster { get;set; }

        public async Task OnGetAsync()
        {
            Monster = await _context.Monster.ToListAsync();
        }
    }
}
