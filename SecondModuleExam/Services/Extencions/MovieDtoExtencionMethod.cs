using SecondModuleExam.Services.Dtos;

namespace SecondModuleExam.Services.Extencions;

public static class MovieDtoExtencionMethod
{
    public static double GetMinutesInHours(this MovieDto movie)
    {
        var hours = movie.DurationMinutes / 60;
        return hours;
    }




    public static long GetCountOfEarnings(this List<MovieDto> movies)
    {
        var count = 0l;
        foreach (var movie in movies)
        {

            count +=movie.BoxOfficeEarnings;
        }
        return count;
    }
}
