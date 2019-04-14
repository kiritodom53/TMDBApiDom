using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetFavoriteTvShowsEndpoint : Endpoint
    {
        public AccountGetFavoriteTvShowsEndpoint(int account_id) : base("account", account_id.ToString(), "favourite", "tv") { }
    }
}
