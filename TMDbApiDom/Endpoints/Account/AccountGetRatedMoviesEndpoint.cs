using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetRatedMoviesEndpoint : Endpoint
    {
        public AccountGetRatedMoviesEndpoint(int account_id) : base("account", account_id.ToString(), "rated", "movies") { }
    }
}
