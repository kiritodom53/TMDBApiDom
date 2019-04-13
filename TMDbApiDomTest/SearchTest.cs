using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.SidewayClasses.WrapperClasses;
using TMDbApiDom.Dto.Search;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro SearchTest
    /// </summary>
    [TestClass]
    public class SearchTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task PersonDetailTest()
        {
            ResultObject<SearchMovie> searchMovie = await mdb.SearchMovie("Lord of The R", new UrlParameters { });
            
            Console.WriteLine("Search movie total results: {0}", searchMovie.total_results);

            Assert.IsTrue(searchMovie != null);
        }
    }
}
