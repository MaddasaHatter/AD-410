using System.ComponentModel;

namespace PokemonReviewApp.Models
{
    public class PokemonCatergory
    {
        public  int Id { get; set; }
        public  int CategoryId { get; set; }
        public  Pokemon Pokemon { get; set; }
        public  Catergory Catergory  { get; set; }
    }
}
