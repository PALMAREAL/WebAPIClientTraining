using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebAPIClientTmdb
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessTmdb();
        }

        private static async Task ProcessTmdb()
        {
            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            client.DefaultRequestHeaders.Add("User-Agent", ".TMDB Movie Database");

            var stringTask = client.GetStringAsync("https://api.themoviedb.org/3/movie/top_rated?api_key=b666aeddc5be93fb6241a328e510bf9e&language=en-US&page=1");
   
            var response = await stringTask;

            Console.Write(response);

        }
    }
}
