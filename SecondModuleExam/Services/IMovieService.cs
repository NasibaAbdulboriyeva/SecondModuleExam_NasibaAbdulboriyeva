using SecondModuleExam.Services.Dtos;

namespace SecondModuleExam.Services
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMoviesByDirector(string director);
        MovieDto GetTopRatedMovie();
        List<MovieDto> GetMovieReleasedAfterYear(DateTime year);
        MovieDto GetHighGrossingMovie();
        List<MovieDto> SearchMoviesByTittle(string keyword);
        List<MovieDto> GetMoviesWithInDurationRange(int minMinutes, int maxMinutes);
        long GetTotalBoxOfficeEarningsByDirector(string director);
        List<MovieDto> GetMoviesSortedByRating();
        List<MovieDto> GetRecentMovies(DateTime year);
    }
}