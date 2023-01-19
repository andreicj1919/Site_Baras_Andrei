namespace Site_Baras_Andrei.Models
{
    public class ValoareNutritionala
    {
        public int ID { get; set; }
        public string Kcal { get; set; }
        public ICollection<Produs>? Produse { get; set; } //navigation property
    }
}
