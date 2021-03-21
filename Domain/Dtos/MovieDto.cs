using System;
using System.Collections.Generic;

namespace Domain
{
    public class MovieDto
    {
        public int page { get; set; }

        public List<ResultDto> results { get; set; }

        public int total_pages { get; set; }

        public int total_results { get; set; }
    }
}
