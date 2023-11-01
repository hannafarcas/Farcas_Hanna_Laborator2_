using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farcas_Hanna_Laborator2.Data;
using Farcas_Hanna_Laborator2.Models;

namespace Farcas_Hanna_Laborator2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context _context;

        public DetailsModel(Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
