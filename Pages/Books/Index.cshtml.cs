﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farcas_Hanna_Laborator2.Data;
using Farcas_Hanna_Laborator2.Models;

namespace Farcas_Hanna_Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context _context;

        public IndexModel(Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
                Book = await _context.Book.Include(b => b.Author).ToListAsync();

            }
        }
    }
}