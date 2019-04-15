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
using TMDbApiDom.Dto.Movies;
using TMDbApiDom.Dto.People;
using TMDbApiDom.Dto.Search;
using TMDbApiDom.Dto.Trending;
using TMDbApiDom.Dto.Tvs;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;
using TMDbApiDom.Dto.Discover;
using TMDbApiDom.Dto.Authentication;
using TMDbApiDom.Endpoints.Authentication;
using TMDbApiDom.Dto.Find;
using TMDbApiDom.Endpoints.Find;
using TMDbApiDom.Dto.Movies.SubClasses;

namespace TMDbApiDom
{
    public class TmdbClient
    {
        private string apikey;
        private HttpClient client = new HttpClient();
        private string baseApiUrl = "https://api.themoviedb.org/3/";
        private SessionToken sessionToken = null;

        public TmdbClient(string apikey)
        {
            this.apikey = apikey;
        }

        public async Task<RequestToken> CreateRequestToken()
        {
            return await this.Get<RequestToken>(new AuthenticationGetCreateRequestTokenEndpoint(), new UrlParameters());
        }

        public async Task<bool> ValidateCredentials(string username, string password, string request_token)
        {
            try
            {
                BodyData bodyData = new BodyData()
            {
                {"username", username },
                {"password", password },
                {"request_token", request_token }
            };
                this.sessionToken = await this.Post<SessionToken>(new AuthenticationPostCreateSessionWithLoginEndpoint(), new UrlParameters(), bodyData);
                return true;
            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool IsAuthenticated()
        {

            return this.sessionToken != null;
        }

        public async Task<bool> RateMovie(int movie_id, double value)
        {
            if (!IsAuthenticated())
            {
                return false;
            }

            try
            {
                BodyData bodyData = new BodyData()
                {
                    {"value", value.ToString() }
                };

                await this.Post<ResponseObject>(new MoviesPostRateMovieEndpoint(movie_id), new UrlParameters()
                {
                    {"session_id", this.sessionToken.session_id }
                }, bodyData);

                return true;

            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<SessionToken> CreateSession(string request_token)
        {
            BodyData bodyData = new BodyData()
            {
                {"request_token", request_token }
            };
            return await this.Post<SessionToken>(new AuthenticationPostCreateSessionEndpoint(), new UrlParameters(), bodyData);
        }

        public async Task<bool> Logout()
        {
            try
            {
                BodyData bodyData = new BodyData()
            {
                {"session_id", this.sessionToken.session_id }
            };
                await this.Delete<DeleteSession>(new AuthenticationDeleteSessionEndpoint(), new UrlParameters(), bodyData);
                return true;
            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> Login(string username, string password)
        {
            try
            {
                RequestToken requestToken = await this.CreateRequestToken();

                bool sessionTokenCreateSuccesfully = await this.ValidateCredentials(username, password, requestToken.request_token);
                if (sessionTokenCreateSuccesfully)
                {
                    this.sessionToken = await this.CreateSession(requestToken.request_token);
                    return true;
                }
            }
            catch (ApiException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return false;
        }

        // ===================== Find by ID

        public async Task<FindResponseObject<FindMovie>> FindMovieById(string external_id, string external_source, UrlParameters parameters)
        {
            parameters.Add("external_source", external_source);
            return await this.Get<FindResponseObject<FindMovie>>(new FindGetFindByID(external_id), parameters);
        }

        public async Task<FindResponseObject<FindTv>> FindTvById(string external_id, string external_source, UrlParameters parameters)
        {
            parameters.Add("external_source", external_source);
            return await this.Get<FindResponseObject<FindTv>>(new FindGetFindByID(external_id), parameters);
        }

        public async Task<FindResponseObject<FindTv>> FindPersonById(string external_id, string external_source, UrlParameters parameters)
        {
            parameters.Add("external_source", external_source);
            return await this.Get<FindResponseObject<FindTv>>(new FindGetFindByID(external_id), parameters);
        }


        // ===================== Discover

        public async Task<ResultObject<DiscoverMovie>> DiscoverMovie(UrlParameters parameters)
        {
            return await this.Get<ResultObject<DiscoverMovie>>(new DiscoverGetMovieDiscoverEndpoint(), parameters);
        }

        public async Task<ResultObject<DiscoverTv>> DiscoverTv(UrlParameters parameters)
        {
            return await this.Get<ResultObject<DiscoverTv>>(new DiscoverGetTvDiscoverEndpoint(), parameters);
        }

        // ===================== Movie
        public async Task<Movie> GetMovieDetails(int movie_id, UrlParameters parameters)
        {
            return await this.Get<Movie>(new MoviesGetDetailsEndpoint(movie_id), parameters);
        }

        public async Task<ResultObject<UpComing>> GetUpcomingMovies(UrlParameters parameters)
        {
            return await this.Get<ResultObject<UpComing>>(new MoviesGetUpcomingEndpoint(), parameters);
        }

        public async Task<ResultObject<TopRated>> GetTopRatedMovies(UrlParameters parameters)
        {
            return await this.Get<ResultObject<TopRated>>(new MoviesGetTopRatedEndpoint(), parameters);
        }

        public async Task<ResultObject<SimilarMovie>> GetSimilarMovie(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<SimilarMovie>>(new MoviesGetSimilarMoviesEndpoint(movie_id), parameters);
        }

        public async Task<MovieKeywords> MovieKeywords(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieKeywords>(new MoviesGetKeywordsEndpoint(movie_id), parameters);
        }

        public async Task<MovieExternalID> MovieExternalId(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieExternalID>(new MoviesGetExternalIDsEndpoint(movie_id), parameters);
        }

        public async Task<MovieCredit> MovieCredit(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieCredit>(new MoviesGetCreditsEndpoint(movie_id), parameters);
        }

        public async Task<MovieChanges> MovieChanges(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieChanges>(new MoviesGetChangesEndpoint(movie_id), parameters);
        }

        public async Task<MovieReleaseDates> MovieReleaseDates(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieReleaseDates>(new MoviesGetReleaseDatesEndpoint(movie_id), parameters);
        }

        public async Task<MovieAlternativeTitles> MovieAlternativeTitles(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieAlternativeTitles>(new MoviesGetAlternativeTitlesEndpoint(movie_id), parameters);
        }

        public async Task<MovieTranslation<Translations<MovieTranslationsData>>> MovieTranslation(int movie_id, UrlParameters parameters)
        {
            return await this.Get<MovieTranslation<Translations<MovieTranslationsData>>>(new MoviesGetTranslationsEndpoint(movie_id), parameters);
        }

        public async Task<ResultObject<MovieRecommendations>> MovieRecomend(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<MovieRecommendations>>(new MoviesGetRecommendationsEndpoint(movie_id), parameters);
        }

        public async Task<ResultObject<MovieReview>> MovieReview(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<MovieReview>>(new MoviesGetReviewsEndpoint(movie_id), parameters);
        }

        public async Task<ResultObject<MoviePopular>> MoviePopular(UrlParameters parameters)
        {
            return await this.Get<ResultObject<MoviePopular>>(new MoviesGetPopularEndpoint(), parameters);
        }

        //==========
        public async Task<VideosWrapper> GetMovieVideos(int movie_id, UrlParameters parameters)
        {
            return await this.Get<VideosWrapper>(new MoviesGetVideosEndpoint(movie_id), parameters);
        }

        public async Task<ImagesWrapper> GetMovieImages(int movie_id, UrlParameters parameters)
        {
            return await this.Get<ImagesWrapper>(new MoviesGetImagesEndpoint(movie_id), parameters);
        }

        // ===================== TV
        public async Task<Tv> GetTvDetails(int tv_id, UrlParameters parametrs)
        {
            return await this.Get<Tv>(new TvGetDetailsEndpoint(tv_id), parametrs);
        }

        public async Task<ResultObject<SimilarTv>> GetSimilarTv(int tv_id, UrlParameters parameters)
        {
            return await this.Get<ResultObject<SimilarTv>>(new TvGetSimilarTvShowsEndpoint(tv_id), parameters);
        }

        // ===================== Genres
        public async Task< GenresWrapper> GetGenresMovieList(UrlParameters parameters)
        {
            return await this.Get<GenresWrapper>(new GenresGetMovieListEndpoint(), parameters);
        }

        public async Task<GenresWrapper> GetGenresTvList(UrlParameters parameters)
        {
            return await this.Get<GenresWrapper>(new GenresGetTvListEndpoint(), parameters);
        }

        // ===================== Person
        public async Task<Person> GetPersonDetails(int person_id, UrlParameters parameters)
        {
            return await this.Get<Person>(new PeopleGetDetailsEndpoint(person_id), parameters);
        }

        // ===================== Search
        public async Task<ResultObject<SearchMovie>> SearchMovie(string query, UrlParameters parameters)
        {
            parameters.Add("query", query);
            return await this.Get<ResultObject<SearchMovie>>(new SearchGetSearchMoviesEndpoint(), parameters);
        }

        // ===================== Trending
        public async Task<ResultObject<TrendingMovie>> GetTrendingMovies(TimeWindow time, UrlParameters parameters)
        {
            return await this.Get<ResultObject<TrendingMovie>>(new TrendingGetTrendingEndpoint(MediaType.MOVIE, time), parameters);
        }

        // ===================== Configuration
        public async Task<List<ConfigurationLanguage>> GetConfigurationLanguages(UrlParameters parameters)
        {
            return await this.Get<List<ConfigurationLanguage>>(new ConfigurationGetLanguagesEndpoint(), parameters);
        }

        /// <summary>
        /// Získá data
        /// </summary>
        /// <param name="endPoint">Endpoint</param>
        /// <param name="parametrs">Parametry</param>
        /// <returns>json in string</returns>
        protected async Task<T> Get<T>(Endpoint endPoint, UrlParameters parameters)
        {
            string url = this.BuildUrl(this.baseApiUrl + endPoint.GetUrl(), parameters);
            //Console.WriteLine("url : {0}", url);

            HttpResponseMessage response = await client.GetAsync(url);

            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ResponseObject err = JsonConvert.DeserializeObject<ResponseObject>(result);
                throw new ApiException(response.StatusCode, err.status_code, err.status_message);
            }

            return JsonConvert.DeserializeObject<T>(result);
        }

        protected async Task<T> Post<T>(Endpoint endPoint, UrlParameters parameters, BodyData bodyData)
        {
            string url = this.BuildUrl(this.baseApiUrl + endPoint.GetUrl(), parameters);
            //Console.WriteLine("url : {0}", url);

            HttpResponseMessage response = await client.PostAsync(url, bodyData.GetStringContent());

            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ResponseObject err = JsonConvert.DeserializeObject<ResponseObject>(result);
                throw new ApiException(response.StatusCode, err.status_code, err.status_message);
            }

            return JsonConvert.DeserializeObject<T>(result);
        }

        protected async Task<T> Delete<T>(Endpoint endPoint, UrlParameters parameters, BodyData bodyData)
        {
            string url = this.BuildUrl(this.baseApiUrl + endPoint.GetUrl(), parameters);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(url),
                Content = bodyData.GetStringContent()
            };
            HttpResponseMessage response = await client.SendAsync(request);

            string result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                ResponseObject err = JsonConvert.DeserializeObject<ResponseObject>(result);
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
            parameters.Add("api_key", this.apikey);
            builder.Query = Helpers.EncodeDictionary(parameters);

            return builder.ToString();
        }

    }
}
