using System.Security.Policy;

namespace Site_Baras_Andrei.Models
{
    public class Produs
    {
        public int ID { get; set; }
        public string DenumireProdus { get; set; }
        public int? IngredientID { get; set; }
        public Ingredient? Ingredient { get; set; }

        public int? ValoareNutritionalaID { get; set; }
        public ValoareNutritionala? ValoareNutritionala { get; set; }


    }//navigation property
}
