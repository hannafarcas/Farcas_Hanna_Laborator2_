using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farcas_Hanna_Laborator2.Data;
using Farcas_Hanna_Laborator2.Models;
using Farcas_Hanna_Laborator2.Models.ViewModels;

namespace Farcas_Hanna_Laborator2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context _context;

        public IndexModel(Farcas_Hanna_Laborator2.Data.Farcas_Hanna_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }
        public int BookID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            CategoryData = new CategoryIndexData();
            CategoryData.Categories = await _context.Category
            .Include(c => c.BookCategories)
                .ThenInclude(bc => bc.Book)
            .OrderBy(i => i.CategoryName)
            .ToListAsync();


            if (id != null)
            {
                CategoryID = id.Value;
                Category category = CategoryData.Categories
                    .Where(i => i.ID == id.Value)
                    .Single();
                CategoryData.Books = category.BookCategories.Select(bc => bc.Book).ToList();
            }
        }
    }
}
