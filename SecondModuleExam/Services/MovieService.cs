using SecondModuleExam.Repositories;
using SecondModuleExam.Services.Dtos;

namespace SecondModuleExam.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private List<MovieDto> _movies;
    public MovieService()
    {
        _movieRepository = new MovieRepository();

    }
    public List<MovieDto> GetAllMoviesByDirector(string director)
    {
        var allMovies = _movieRepository.ReadAllMovies();
        List<MovieDto>movies = new List<MovieDto>();

        foreach (var movie in allMovies)
        {
            if (movie.Director == director)
            {
                movies.Add(movie);

            }

        }
        return movies;
    }

    public MovieDto GetHighGrossingMovie()
    {
        var mostEarningMovie = new MovieDto();
        foreach (var movie in _movies)
        {
            if (movie.BoxOfficeEarnings > mostEarningMovie.BoxOfficeEarnings)
            {
                mostEarningMovie = movie;
            }
        }
        return mostEarningMovie;

    }

    public List<MovieDto> GetMovieReleasedAfterYear(DateTime year)
    {
        var _movies=_movieRepository.ReadAllMovies();
        foreach (var movie in _movies)
        {
            if (movie.RealeseDate == year)
            {

            }
        }
        return 
    }


    public List<MovieDto> GetMoviesSortedByRating()
    {

        
    }

    public List<MovieDto> GetMoviesWithInDurationRange(int minMinutes, int maxMinutes)
    {
        throw new NotImplementedException();
    }

    public List<MovieDto> GetRecentMovies(DateTime year)
    {
     
        var moviesByYear=new List<MovieDto>();
        foreach (var movie in _movies )
        {
            if (movie.RealeseDate == year)
            {
                moviesByYear.Add(movie);
            }
        }
        return moviesByYear;

    }

    public MovieDto GetTopRatedMovie()
    {
        

        var maxRating = new MovieDto();
        foreach (var movie in _movies)
        {
            if (movie.Rating > maxRating.Rating)
            {
                maxRating = movie;
            }
        }
        return maxRating;

    }

    public long GetTotalBoxOfficeEarningsByDirector(string director)
    {
        var res = 0l;
        var directorsMovies = GetAllMoviesByDirector(director);
        foreach (var movie in directorsMovies)
        {
            res += movie.BoxOfficeEarnings;
        }
        return res;



    }

    public List<MovieDto> SearchMoviesByTittle(string keyword)
    {
        var  movies =new List<MovieDto>();
        foreach (var movie in _movies)
        {
            if (movie.Tittle == keyword)
            {
                movies.Add(movie);
            }
        }
        return movies;
    }
}
