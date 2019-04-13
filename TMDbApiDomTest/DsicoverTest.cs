using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using TMDbApiDom.Dto.Discover;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;

namespace TMDbApiDomTest
{
    [TestClass]
    public class DsicoverTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }


        [TestMethod]
        public async Task DiscoverMovieTest()
        {
            ResultObject<DiscoverMovie> movieDiscover = await mdb.DiscoverMovie(new UrlParameters {
                {"language", "cs-CZ"},
                {"include_adult", "false" },
                {"primary_release_year", "2019" }
            });

            Console.WriteLine("Discover movie results: {0}", movieDiscover.total_results);

            Assert.IsTrue(movieDiscover.results != null);
        }

        [TestMethod]
        public async Task DiscoverTvTest()
        {
            ResultObject<DiscoverTv> tvDiscover = await mdb.DiscoverTv(new UrlParameters {

                {"language", "cs-CZ"},
                {"include_adult", "false" },
                {"primary_release_year", "2019" }
            });

            Console.WriteLine("TV movie results: {0}", tvDiscover.total_results);

            Assert.IsTrue(tvDiscover.results != null);
        }
    }
}
