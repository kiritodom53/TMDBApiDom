using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Companies
{
    public class CompaniesGetAlternativeNamesEndpoint : Endpoint
    {
        public CompaniesGetAlternativeNamesEndpoint(int company_id) : base("company", company_id.ToString(), "alternative_names") { }
    }
}
