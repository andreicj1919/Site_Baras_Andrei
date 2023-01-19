﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly Site_Baras_Andrei.Data.Site_Baras_AndreiContext _context;

        public IndexModel(Site_Baras_Andrei.Data.Site_Baras_AndreiContext context)
        {
            _context = context;
        }

        public IList<ValoareNutritionala> ValoareNutritionala { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ValoareNutritionala != null)
            {
                ValoareNutritionala = await _context.ValoareNutritionala.ToListAsync();
            }
        }
    }
}
