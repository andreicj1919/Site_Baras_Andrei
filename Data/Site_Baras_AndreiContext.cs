using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site_Baras_Andrei.Models;

namespace Site_Baras_Andrei.Data
{
    public class Site_Baras_AndreiContext : DbContext
    {
        public Site_Baras_AndreiContext (DbContextOptions<Site_Baras_AndreiContext> options)
            : base(options)
        {
        }

        public DbSet<Site_Baras_Andrei.Models.Produs> Produs { get; set; } = default!;

        public DbSet<Site_Baras_Andrei.Models.Ingredient> Ingredient { get; set; }

        public DbSet<Site_Baras_Andrei.Models.ValoareNutritionala> ValoareNutritionala { get; set; }


    }
}
