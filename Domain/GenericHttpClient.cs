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
        public HttpClient HttpClient { get; set; }

        public GenericHttpClient()
        {
            HttpClient = new HttpClient();
        }

        public async Task<Movie> SendAsync(string uri)
        {

            HttpClient.DefaultRequestHeaders.Accept.Clear();

            HttpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            HttpClient.DefaultRequestHeaders.Add("User-Agent", ".TMDB Movie Database");

            var response = await HttpClient.GetStreamAsync(uri);

            var movies = await JsonSerializer.DeserializeAsync<Movie>(response);

            return movies;  
        }
    }
}
