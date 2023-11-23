namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        // One to Many relationships
        public ICollection<Review> Reviews { get; set; }

        //Many to Many relationships
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }

    }
}
