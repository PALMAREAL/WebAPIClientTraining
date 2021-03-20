using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPIClientDotnetRepo
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }

        private static async Task ProcessRepositories()
        {

        }
    }
}
