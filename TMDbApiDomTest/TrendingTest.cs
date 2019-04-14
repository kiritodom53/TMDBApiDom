using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;
using TMDbApiDom.Dto;
using TMDbApiDom.Dto.Trending;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro TrendingTest
    /// </summary>
    [TestClass]
    public class TrendingTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task TrendingMovieTest()
        {
            ResultObject<TrendingMovie> trendingMovie = await mdb.GetTrendingMovies(TimeWindow.WEEK, new UrlParameters { });

            Console.WriteLine("Trending movie total results: {0}", trendingMovie.total_results);
            Console.WriteLine("Trending movie total pages: {0}", trendingMovie.total_pages);
            Console.WriteLine("Trending movie index 0: {0}", trendingMovie.results[5].title);

            Assert.IsTrue(trendingMovie != null);
        }
    }
}
