using System.Net.Http.Json;
using webAssemblyLab1.Model;

namespace webAssemblyLab1.Services
{
    public class MovieService
    {
        private readonly HttpClient client;

        public MovieService(HttpClient client)
        {
            this.client = client;

        }

        public async Task<IEnumerable<Genre>> GetGenreAsync()
        {
            var arrayOfGenre = await client.GetFromJsonAsync<MovieInfo>("https://api.themoviedb.org/3/movie/550?api_key=989763942fa4f236cb34de985f499dc6");
            return arrayOfGenre.genres;
        }

        public async Task<string> GetMovieIdAsync()
        {
            var apiData = await client.GetFromJsonAsync<MovieInfo>("https://api.themoviedb.org/3/movie/550?api_key=989763942fa4f236cb34de985f499dc6");
            return apiData.title;
        }
    }
}
