using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain
{
    public class GenericHttpClient
    {
        public async Task<Movie> SendAsync()
        {
            var client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            client.DefaultRequestHeaders.Add("User-Agent", ".TMDB Movie Database");

            var response = await client.GetStreamAsync("https://api.themoviedb.org/3/movie/top_rated?api_key=b666aeddc5be93fb6241a328e510bf9e&language=en-US&page=1");

            var movies = await JsonSerializer.DeserializeAsync<Movie>(response);

            return movies;  
        }
    }
}
