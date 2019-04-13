using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMDbApiDom;
using System.Threading.Tasks;

namespace TMDbApiDomTest
{
    /// <summary>
    /// Souhrnný popis pro AuthenticationTest
    /// </summary>
    [TestClass]
    public class AuthenticationTest
    {
        private TmdbClient mdb;

        [TestInitialize]
        public void InitializeAsync()
        {
            mdb = new TmdbClient("00bd97eb398972b1934ecaa963822fc8");
        }

        [TestMethod]
        public async Task LoginAndLogoutTest()
        {
            bool isLogin = await mdb.Login("dom53", "D3rT51lK");
            Console.WriteLine("isLogin: {0}", isLogin);
            Assert.IsTrue(isLogin);

            bool isLogout = await mdb.Logout();
            Console.WriteLine("isLogout: {0}", isLogout);
            Assert.IsTrue(isLogout);
        }
    }
}
