using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using TMDbApiDom.Dto;
using TMDbApiDom.Dto.Discover;
using TMDbApiDom.Dto.Movies;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;

namespace TMDbApiDomTest
{
    [TestClass]
    public class TMDbApiAppTests
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

            Assert.IsTrue(movieDiscover.results != null);
        }
    }
}
