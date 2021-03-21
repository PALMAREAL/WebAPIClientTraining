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
           var movies =  await new MovieService().GetMoviesAsync();

            movies.results.ForEach(m => Console.WriteLine(m.title));
        }
    }
}


