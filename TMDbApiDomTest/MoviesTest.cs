using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.Movies;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;
using TMDbApiDom.Dto.Authentication;
using TMDbApiDom.Dto.Movies.SubClasses;
using TMDbApiDom.Dto.Tvs;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro MoviesTest
    /// </summary>
    [TestClass]
    public class MoviesTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task GetMovieDetailTest()
        {
            Movie movie = await mdb.GetMovieDetails(120, new UrlParameters { });
            Assert.AreEqual("The Lord of the Rings: The Fellowship of the Ring", movie.title);
            Assert.AreEqual(120, movie.id);
        }

        [TestMethod]
        public async Task UpcomingMovieTest()
        {
            ResultObject<UpComing> upMovie = await mdb.GetUpcomingMovies(new UrlParameters { });

            Console.WriteLine("Upcoming movie total result : {0}", upMovie.total_results);

            Assert.IsTrue(upMovie.results != null);
        }

        [TestMethod]
        public async Task TopRatedMoviesTest()
        {
            ResultObject<TopRated> topMovie = await mdb.GetTopRatedMovies(new UrlParameters { });

            Console.WriteLine("Top rated movie total result : {0}", topMovie.total_results);

            Assert.IsTrue(topMovie.results != null);
        }

        [TestMethod]
        public async Task SimilarMovieTest()
        {
            ResultObject<SimilarMovie> similarMovie = await mdb.GetSimilarMovie(299537, new UrlParameters { });

            Console.WriteLine("Similar movie total result : {0}", similarMovie.total_results);

            Assert.IsTrue(similarMovie.results != null);
        }

        [TestMethod]
        public async Task MoviesVideoTest()
        {
            VideosWrapper moviesVideos = await mdb.GetMovieVideos(299537, new UrlParameters { });

            Console.WriteLine("Movie videos total result : {0}", moviesVideos.results.Length);

            Assert.IsTrue(moviesVideos.results != null);
        }

        [TestMethod]
        public async Task MoviesImagesTest()
        {
            ImagesWrapper moviesImages = await mdb.GetMovieImages(299537, new UrlParameters { });

            Console.WriteLine("Movie img backdrops total result : {0}", moviesImages.backdrops.Length);
            Console.WriteLine("Movie img posters result : {0}", moviesImages.posters.Length);

            Assert.IsTrue(moviesImages.backdrops != null);
            Assert.IsTrue(moviesImages.posters != null);
        }

        [TestMethod]
        public async Task PostMovieRatingTest()
        {
            bool isLogin = await mdb.Login("dom53", "D3rT51lK");

            bool movieRated = await mdb.Rate("tv", 63926, 5);

            Console.WriteLine("isLogin: {0}", isLogin);
            Console.WriteLine("rated: {0}", movieRated);

			Assert.IsTrue(isLogin);
			Assert.IsTrue(movieRated);
        }

        [TestMethod]
        public async Task MovieKeywordTest()
        {
            MovieKeywords moviesKeywords = await mdb.MovieKeywords(299537, new UrlParameters { });

            Console.WriteLine("keywords: {0}", moviesKeywords.keywords[0].name);

            Assert.IsTrue(moviesKeywords != null);
        }

        [TestMethod]
        public async Task MovieExternalIdsTest()
        {
            MovieExternalID moviesExt = await mdb.MovieExternalId(299537, new UrlParameters { });

            Console.WriteLine("id: {0}", moviesExt.id);
            Console.WriteLine("imdb id: {0}", moviesExt.imdb_id);
            Console.WriteLine("fb id: {0}", moviesExt.facebook_id);
            Console.WriteLine("ig id: {0}", moviesExt.instagram_id);
            Console.WriteLine("twitter id: {0}", moviesExt.twitter_id);

            Assert.IsTrue(moviesExt != null);
        }

        [TestMethod]
        public async Task MovieCreditTest()
        {
            MovieCredit moviesCredits = await mdb.MovieCredit(299537, new UrlParameters { });

			Console.WriteLine("id: {0}", moviesCredits.id);
			Console.WriteLine("id: {0}", moviesCredits.cast[0].cast_id);
			Console.WriteLine("cast name [0]: {0}", moviesCredits.cast[0].name);
            Console.WriteLine("crew name [0]: {0}", moviesCredits.crew[0].name);

            Assert.IsTrue(moviesCredits != null);
        }

        [TestMethod]
        public async Task MovieChangesTest()
        {
            MovieChanges<Changes<MovieItems>> movieChanges = await mdb.MovieChanges(120, new UrlParameters { });

            Console.WriteLine("movieChanges length: {0}", movieChanges.changes.Length);
            /*Console.WriteLine("movieChanges key: {0}", movieChanges.changes[0].key);
            Console.WriteLine("movieChanges items length: {0}", movieChanges.changes[0].items.Length);
            Console.WriteLine("movieChanges items id: {0}", movieChanges.changes[0].items[0].id);
            Console.WriteLine("movieChanges items action: {0}", movieChanges.changes[0].items[0].action);*/

            Assert.IsTrue(movieChanges != null);
        }

        [TestMethod]
        public async Task MovieReleaseDatesTest()
        {
            MovieReleaseDates movieRelease = await mdb.MovieReleaseDates(299537, new UrlParameters { });

            Console.WriteLine("movieRelease id: {0}", movieRelease.id);
            Console.WriteLine("movieRelease result length id: {0}", movieRelease.results.Length);
            Console.WriteLine("movieRelease result iso: {0}", movieRelease.results[0].iso_3166_1);
            Console.WriteLine("movieRelease result releaseDates length: {0}", movieRelease.results[0].release_dates.Length);
            Console.WriteLine("movieRelease result releaseDates type: {0}", movieRelease.results[0].release_dates[0].type);
            Console.WriteLine("movieRelease result releaseDates date: {0}", movieRelease.results[0].release_dates[0].release_date);
            Console.WriteLine("movieRelease result releaseDates certification: {0}", movieRelease.results[0].release_dates[0].certification);
            Console.WriteLine("movieRelease result releaseDates note: {0}", movieRelease.results[0].release_dates[0].note);

            Assert.IsTrue(movieRelease != null);
        }

        [TestMethod]
        public async Task MovieAlternativeTitles()
        {
            MovieAlternativeTitles movieAlternativeTitles = await mdb.MovieAlternativeTitles(299537, new UrlParameters { });

            Console.WriteLine("movieAlternativeTitles id: {0}", movieAlternativeTitles.id);
            Console.WriteLine("movieAlternativeTitles length {0}", movieAlternativeTitles.titles.Length);
            Console.WriteLine("movieAlternativeTitles length title: {0}", movieAlternativeTitles.titles[0].title);
            Console.WriteLine("movieAlternativeTitles length type: {0}", movieAlternativeTitles.titles[0].type);
            Console.WriteLine("movieAlternativeTitles length iso: {0}", movieAlternativeTitles.titles[0].iso_3166_1);

            Assert.IsTrue(movieAlternativeTitles != null);
        }

        [TestMethod]
        public async Task MoiveTranslationsTest()
        {
            Translations<TranslationObject<MovieTranslation>> movieTranslation = await mdb.MovieTranslation(120, new UrlParameters { });

            Console.WriteLine("movieTranslation id : {0}", movieTranslation.id);
            Console.WriteLine("movieTranslation length: {0}", movieTranslation.translations.Length);
            Console.WriteLine("movieTranslation data Title: {0}", movieTranslation.translations[0].data.title);
            Console.WriteLine("movieTranslation data Homepage: {0}", movieTranslation.translations[0].data.homepage);
            Console.WriteLine("movieTranslation data Overwiev: {0}", movieTranslation.translations[0].data.overview);

            Assert.IsTrue(movieTranslation != null);
        }

        [TestMethod]
        public async Task MovieRecomendTest()
        {
            ResultObject<MovieRecommendations> movieRecomen = await mdb.MovieRecomend(120, new UrlParameters { });

            Console.WriteLine("movieRecomen total_pages: {0}", movieRecomen.total_pages);
            Console.WriteLine("movieRecomen total_results: {0}", movieRecomen.total_results);
            Console.WriteLine("movieRecomen results: {0}", movieRecomen.results[0].title);

            Assert.IsTrue(movieRecomen != null);
        }

        [TestMethod]
        public async Task MovieReviewTest()
        {
            ResultObject<MovieReview> movieReview = await mdb.MovieReview(120, new UrlParameters { });

            Console.WriteLine("movieReview id: {0}", movieReview.id);
            Console.WriteLine("movieReview total_pages: {0}", movieReview.total_pages);
            Console.WriteLine("movieReview total_results: {0}", movieReview.total_results);
            Console.WriteLine("movieReview result id: {0}", movieReview.results[0].id);
            Console.WriteLine("movieReview result author: {0}", movieReview.results[0].author);
            Console.WriteLine("movieReview result content: {0}", movieReview.results[0].content);
            Console.WriteLine("movieReview result url: {0}", movieReview.results[0].url);

            Assert.IsTrue(movieReview != null);
        }

        [TestMethod]
        public async Task MoviePopularTest()
        {
            ResultObject<MoviePopular> moviePopular = await mdb.MoviePopular(new UrlParameters { });

            Console.WriteLine("moviePopular id: {0}", moviePopular.id);
            Console.WriteLine("moviePopular total_pages: {0}", moviePopular.total_pages);
            Console.WriteLine("moviePopular total_results: {0}", moviePopular.total_results);
            Console.WriteLine("moviePopular result id: {0}", moviePopular.results[5].id);
            Console.WriteLine("moviePopular result title: {0}", moviePopular.results[5].title);

            Assert.IsTrue(moviePopular != null);
        }

		[TestMethod]
		public async Task MovieVideoWrapperTest()
		{
			VideosWrapper movieVideo = await mdb.GetMovieVideos(120, new UrlParameters { });

			Console.WriteLine("video length : {0}", movieVideo.results.Length);
			Console.WriteLine("video name : {0}", movieVideo.results[0].name);

			Assert.IsTrue(movieVideo != null);
		}

		[TestMethod]
		public async Task MovieImgWrapperTest()
		{
			ImagesWrapper movieImg = await mdb.GetMovieImages(120, new UrlParameters { });

			Console.WriteLine("imgmovieImgVideo backdrop length : {0}", movieImg.backdrops.Length);
			Console.WriteLine("movieImg backdrop file_path : {0}", movieImg.backdrops[0].file_path);
			Console.WriteLine("movieImg posters length : {0}", movieImg.posters.Length);
			Console.WriteLine("movieImg posters file_path : {0}", movieImg.posters[0].file_path);

			Assert.IsTrue(movieImg != null);
		}
	}
}
