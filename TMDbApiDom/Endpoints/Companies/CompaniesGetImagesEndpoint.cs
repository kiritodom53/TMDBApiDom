using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Companies
{
    public class CompaniesGetImagesEndpoint : Endpoint
    {
        public CompaniesGetImagesEndpoint(int company_id) : base("company", company_id.ToString(), "images") { }
    }
}
