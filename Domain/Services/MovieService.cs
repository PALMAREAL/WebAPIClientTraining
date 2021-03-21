using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MovieService : IMovieService
    {
        protected GenericHttpClient GenericHttpClient { get; set; }

        public MovieService()
        {
            GenericHttpClient = new GenericHttpClient();
        }

        public async Task<MovieDto> GetMoviesAsync()
        {
            return await GenericHttpClient.SendAsync<MovieDto>("https://api.themoviedb.org/3/movie/top_rated?api_key=b666aeddc5be93fb6241a328e510bf9e&language=en-US&page=1");
        }
    }
}

