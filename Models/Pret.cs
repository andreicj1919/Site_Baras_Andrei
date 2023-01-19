namespace Site_Baras_Andrei.Models
{
    public class Pret
    {
        public int ID { get; set; }
        public string PretProdus { get; set; }
        public ICollection<Produs>? Produse { get; set; } //navigation property
    }
}
