using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Baras_Andrei.Data;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Pages.Ingrediente
{
    public class DeleteModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public DeleteModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Ingredient Ingredient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ingredient == null)
            {
                return NotFound();
            }

            var ingredient = await _context.Ingredient.FirstOrDefaultAsync(m => m.ID == id);

            if (ingredient == null)
            {
                return NotFound();
            }
            else 
            {
                Ingredient = ingredient;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ingredient == null)
            {
                return NotFound();
            }
            var ingredient = await _context.Ingredient.FindAsync(id);

            if (ingredient != null)
            {
                Ingredient = ingredient;
                _context.Ingredient.Remove(Ingredient);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
