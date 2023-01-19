using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Site_Baras_Andrei.Data;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Pages.Produse
{
    public class CreateModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public CreateModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["IngredientID"] = new SelectList(_context.Set<Ingredient>(), "ID",
        "NumeIngredient");
            ViewData["ValoareNutritionalaID"] = new SelectList(_context.Set<ValoareNutritionala>(), "ID",
        "Kcal");
            return Page();


        }

        [BindProperty]
        public Produs Produs { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
