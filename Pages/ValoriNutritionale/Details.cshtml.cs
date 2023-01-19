using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Site_Baras_Andrei.Data;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Pages.ValoriNutritionale
{
    public class DetailsModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public DetailsModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

      public ValoareNutritionala ValoareNutritionala { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ValoareNutritionala == null)
            {
                return NotFound();
            }

            var valoarenutritionala = await _context.ValoareNutritionala.FirstOrDefaultAsync(m => m.ID == id);
            if (valoarenutritionala == null)
            {
                return NotFound();
            }
            else 
            {
                ValoareNutritionala = valoarenutritionala;
            }
            return Page();
        }
    }
}
