namespace PokemonReviewApp.Dto
{
    //Dtos are blocking the data that you dont want to display to the user. It is kind of a filtering system that you check what kind of data you are going to show or not.
    public class PokemonDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
