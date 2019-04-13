using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;
using TMDbApiDom.Dto.People;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro PeopleTest
    /// </summary>
    [TestClass]
    public class PeopleTest
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
            Person person = await mdb.GetPersonDetails(1185787, new UrlParameters());

            Console.WriteLine("Person: {0}", person.name);

            Assert.AreEqual("Liu Yan", person.name);
        }
    }
}
