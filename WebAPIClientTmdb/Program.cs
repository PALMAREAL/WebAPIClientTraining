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
            var client = new GenericHttpClient();

            var movies = await client.SendAsync();

            movies.results.ForEach(m => Console.WriteLine(m.title));
        }
    }
}


