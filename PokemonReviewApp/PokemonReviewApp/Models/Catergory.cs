namespace PokemonReviewApp.Models
{
    public class Catergory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  ICollection<PokemonCatergory> PokemonCatergories { get; set; }


    }
}
