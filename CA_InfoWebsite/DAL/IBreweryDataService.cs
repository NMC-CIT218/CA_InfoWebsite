using CA_InfoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_InfoWebsite.DAL
{
    /// <summary>
    /// data service interface to read and write an entire file based on the Brewery class
    /// </summary>
    public interface IBreweryDataService
    {
        IEnumerable<Brewery> Read();
        void Write(IEnumerable<Brewery> Breweries);
    }
}