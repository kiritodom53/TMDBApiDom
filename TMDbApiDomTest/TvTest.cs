using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.Tvs;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro TvTest
    /// </summary>
    [TestClass]
    public class TvTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task TvDetailsTest ()
        {
            Tv tv = await mdb.GetTvDetails(63926, new UrlParameters { });

            Console.WriteLine("tv name : {0}", tv.name);

            Assert.AreEqual("One-Punch Man", tv.name);
            Assert.AreEqual(63926, tv.id);
        }

        [TestMethod]
        public async Task SimilarMovieTest()
        {
            ResultObject<SimilarTv> similarTv = await mdb.GetSimilarTv(63926, new UrlParameters { });

            Console.WriteLine("Similar tv total result : {0}", similarTv.total_results);

            Assert.IsTrue(similarTv.results != null);
        }
    }
}
