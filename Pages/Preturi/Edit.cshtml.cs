using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Site_Baras_Andrei.Data;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Pages.Preturi
{
    public class EditModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public EditModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pret Pret { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pret == null)
            {
                return NotFound();
            }

            var pret =  await _context.Pret.FirstOrDefaultAsync(m => m.ID == id);
            if (pret == null)
            {
                return NotFound();
            }
            Pret = pret;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pret).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PretExists(Pret.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PretExists(int id)
        {
          return _context.Pret.Any(e => e.ID == id);
        }
    }
}
