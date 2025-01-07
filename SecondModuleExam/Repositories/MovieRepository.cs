using SecondModuleExam.DataAccess.Entitties;
using System.Text.Json;

namespace SecondModuleExam.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly string _path;
    private List<Movie> _movies;
    public MovieRepository()
    {
        _path = "../../../DataAccess/Data/Movie.json";

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _movies = ReadAllMovies();
    }
    public List<Movie> ReadAllMovies()
    {
        var movies = File.ReadAllText(_path);
        var movieJson = JsonSerializer.Deserialize<List<Movie>>(movies);

        return movieJson;
    }

    public Movie GetMovieById(Guid id)
    {
        foreach (var movie in _movies)
        {
            if (movie.Id == id)
            {
                return movie;
            }
        }
        throw new Exception(" ID not found ");
    }

    public void RemoveMovie(Guid id)
    {
        var removingMovie = GetMovieById(id);
        var res = _movies.Remove(removingMovie);
        SaveData();
    }

    public void UpdateMovie(Movie movie)
    {
        var updatingmovie = GetMovieById(movie.Id);
        var index = _movies.IndexOf(updatingmovie);
        _movies[index] = movie;
        SaveData();
    }

    public Guid WriteMovie(Movie movie)
    {
       
        _movies.Add(movie);
        SaveData();
        return movie.Id;

    }
    private void SaveData()
    {
        var movieJson = JsonSerializer.Serialize(_movies);
        File.WriteAllText(_path, "[]");


    }
}
