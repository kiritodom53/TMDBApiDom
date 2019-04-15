using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.Find;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro FindByIdTest
    /// </summary>
    [TestClass]
    public class FindByIdTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task FindTvByIdTest()
        {
            FindResponseObject<FindTv> FindById = await mdb.FindTvById("tt4508902", "imdb_id", new UrlParameters());

            Console.WriteLine(FindById.tv_results[0].name);

            Assert.IsTrue(FindById != null);
        }

        [TestMethod]
        public async Task FindMovieByIdTest()
        {
            FindResponseObject<FindMovie> FindById = await mdb.FindMovieById("tt0133093", "imdb_id", new UrlParameters());

            //tt0133093
            Console.WriteLine(FindById.movie_results[0].title);

            Assert.IsTrue(FindById != null);
        }
    }
}
