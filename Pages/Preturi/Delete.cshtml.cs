using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Baras_Andrei.Data;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Pages.Preturi
{
    public class DeleteModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public DeleteModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Pret Pret { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pret == null)
            {
                return NotFound();
            }

            var pret = await _context.Pret.FirstOrDefaultAsync(m => m.ID == id);

            if (pret == null)
            {
                return NotFound();
            }
            else 
            {
                Pret = pret;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Pret == null)
            {
                return NotFound();
            }
            var pret = await _context.Pret.FindAsync(id);

            if (pret != null)
            {
                Pret = pret;
                _context.Pret.Remove(Pret);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
