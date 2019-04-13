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
        public async Task PostMovieRatingTest()
        {
            bool isLogin = await mdb.Login("dom53", "D3rT51lK");

            bool movieRated = await mdb.RateMovie(287947, 0);

            Console.WriteLine("isLogin: {0}", isLogin);
            Console.WriteLine("rated: {0}", movieRated);

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
    }
}
