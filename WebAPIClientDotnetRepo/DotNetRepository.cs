using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WebAPIClientDotnetRepo
{
    public class DotNetRepository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
