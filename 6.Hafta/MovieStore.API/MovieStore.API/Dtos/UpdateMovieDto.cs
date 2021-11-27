namespace MovieStore.API.Dtos
{
    public class UpdateMovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Budget { get; set; }
        public int DirectorId { get; set; }
    }
}
