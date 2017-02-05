using CA_InfoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_InfoWebsite.DAL
{
    public interface IBreweryDataService
    {
        IEnumerable<Brewery> Read();
        void Write(IEnumerable<Brewery> Breweries);
    }
}