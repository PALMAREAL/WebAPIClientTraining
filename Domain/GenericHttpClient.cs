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

        public async Task<T> SendAsync<T>(string uri)
        {
            var response = await HttpClient.GetStreamAsync(uri);

            return await JsonSerializer.DeserializeAsync<T>(response);
        }
    }
}
