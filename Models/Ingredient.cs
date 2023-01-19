namespace Site_Baras_Andrei.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string NumeIngredient { get; set; }
        public ICollection<Produs>? Produse { get; set; } //navigation property
    }
}
