using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMDbApiDom.Dto;
using TMDbApiDom.Endpoints;
using TMDbApiDom.Endpoints.Movies;
using TMDbApiDom.Endpoints.People;
using TMDbApiDom.Endpoints.Search;
using TMDbApiDom.Endpoints.Discover;
using TMDbApiDom.Exceptions;
using TMDbApiDom.Endpoints.Trending;
using TMDbApiDom.Endpoints.Configuration;
using TMDbApiDom.Endpoints.Genres;
using TMDbApiDom.Endpoints.Tv;

namespace TMDbApiDom
{
    public class TmdbClient
    {
        private string apikey;
        private HttpClient client = new HttpClient();
        private string baseApiUrl = "https://api.themoviedb.org/3/";

        public TmdbClient(string apikey)
        {
            this.apikey = apikey;
        }
        // ===================== Discover
        public async Task<ResultObject<DiscoverMovie>> DiscoverMovie(UrlParameters parameters)
        {
            return await this.Get<ResultObject<DiscoverMovie>>(new DiscoverMovieEndpoint(), parameters);
        }

        public async Task<ResultObject<DiscoverTv>> DiscoverTv(UrlParameters parameters)
        {
            return await this.Get<ResultObject<DiscoverTv>>(new DiscoverTvEndpoint(), parameters);
        }

        // ===================== Movie
        public async Task<Movie> GetMovieDetails(int movie_id, UrlParameters parameters)
        {
            return await this.Get<Movie>(new MovieDetailsEndpoint(movie_id), parameters);
        }

        public async Task<VideosWrapper> GetMovieVideos(int movie_id, UrlParameters parameters)
        {
            return await this.Get<VideosWrapper>(new MovieVideosEndpoint(movie_id), parameters);
        }

        public async Task<ImagesWrapper> GetMovieImages(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ImagesWrapper>(new MovieImagesEndpoint(movie_id), parameters);
        }

        public async Task<ResultObject<SimilarMovie>> GetSimilarMovie(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<SimilarMovie>>(new MovieSimilarMoviesEndpoint(movie_id), parameters);
        }

        // ===================== TV
        public async Task<Tv> GetTvDetails(int tv_id, UrlParameters parametrs)
        {
            return await this.Get<Tv>(new TvDetailsEndpoint(tv_id), parametrs);
        }

        public async Task<ResultObject<SimilarTv>> GetSimilarTv(int tv_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<SimilarTv>>(new TvSimilarTvEndpoint(tv_id), parameters);
        }

        // ===================== Genres
        public async Task<GenresWrapper> GetGenresMovieList(UrlParameters parameters)
        {
            return await this.Get<GenresWrapper>(new GenresMovieListEndpoint(), parameters);
        }

        public async Task<GenresWrapper> GetGenresTvList(UrlParameters parameters)
        {
            return await this.Get<GenresWrapper>(new GenresTvListEndpoint(), parameters);
        }

        // ===================== Person
        public async Task<Person> GetPersonDetails(int person_id, UrlParameters parameters)
        {
            return await this.Get<Person>(new PersonDetailsEndpoint(person_id), parameters);
        }

        // ===================== Search
        public async Task<ResultObject<SearchMovie>> SearchMovie(string query, UrlParameters parameters)
        {
            parameters.Add("query", query);
            return await this.Get<ResultObject<SearchMovie>>(new SearchMoviesEndpoint(), parameters);
        }

        // ===================== Trending
        public async Task<ResultObject<TrendingMovie>> GetTrendingMovies(TimeWindow time, UrlParameters parameters)
        {
            return await this.Get<ResultObject<TrendingMovie>>(new TrendingEndpoint(MediaType.MOVIE, time), parameters);
        }

        // ===================== Configuration
        public async Task<List<ConfigurationLanguage>> GetConfigurationLanguages(UrlParameters parameters)
        {
            return await this.Get<List<ConfigurationLanguage>>(new ConfigurationLanguagesEndpoint(), parameters);
        }

        /// <summary>
        /// Získá data
        /// </summary>
        /// <param name="endPoint">Endpoint</param>
        /// <param name="parametrs">Parametry</param>
        /// <returns>json in string</returns>
        private async Task<T> Get<T>(Endpoint endPoint, UrlParameters parametrs)
        {
            string url = this.BuildUrl(this.baseApiUrl + endPoint.GetUrl(), parametrs);
            //Console.WriteLine("url : {0}", url);

            HttpResponseMessage response = await client.GetAsync(url);

            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ErrorObject err = JsonConvert.DeserializeObject<ErrorObject>(result);
                throw new ApiException(response.StatusCode, err.status_code, err.status_message);
            }

            return JsonConvert.DeserializeObject<T>(result);
        }

        /// <summary>
        /// Sestaví url s parametrama
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="parameters">Parametry</param>
        /// <returns>URL dotaz</returns>
        private string BuildUrl(string url, UrlParameters parameters)
        {
            var builder = new UriBuilder(url);

            string query = "";
            parameters.Add("api_key", this.apikey);

            foreach (KeyValuePair<string, string> item in parameters)
            {
                query += item.Key + "=" + item.Value + "&";
            }
            query = query.Remove(query.Length - 1); // Odebere poslední &
            builder.Query = query;

            return builder.ToString();
        }

    }
}
