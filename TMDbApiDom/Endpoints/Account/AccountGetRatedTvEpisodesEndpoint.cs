using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetRatedTvEpisodesEndpoint : Endpoint
    {
        public AccountGetRatedTvEpisodesEndpoint(int account_id) : base("account", account_id.ToString(), "rated", "episodes") { }
    }
}
