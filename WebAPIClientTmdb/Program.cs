using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPIClientTmdb
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await ProcessTmdb();
        }       
        
        static async Task ProcessTmdb()
        {
            var client = new GenericHttpClient();

            var movies = await client.SendAsync("https://api.themoviedb.org/3/movie/top_rated?api_key=b666aeddc5be93fb6241a328e510bf9e&language=en-US&page=1");

            movies.results.ForEach(m => Console.WriteLine(m.title));
        }
    }
}


