using SecondModuleExam.DataAccess.Entitties;

namespace SecondModuleExam.Repositories
{
    public interface IMovieRepository
    {
        Guid WriteMovie(Movie movie);
        void RemoveMovie(Guid id);
        void UpdateMovie(Movie movieId);
        Movie GetMovieById(Guid id);
        List<Movie> ReadAllMovies();
        
    }
}