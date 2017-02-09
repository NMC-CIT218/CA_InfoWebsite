using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA_InfoWebsite.Models;

namespace CA_InfoWebsite.DAL
{
    public class BreweryRepository : IBreweryRepository, IDisposable
    {
        private IList<Brewery> _breweries;

        public BreweryRepository()
        {
            _breweries = HttpContext.Current.Session["Breweries"] as IList<Brewery>;
        }


        public IEnumerable<Brewery> SelectAll()
        {
            return _breweries;
        }

        public Brewery SelectOne(int id)
        {
            //Brewery selectedBrewery =
            (from brewery in _breweries
             where brewery.Id == id
             select brewery).FirstOrDefault();

            Brewery selectedBrewery = _breweries.Where(p => p.Id == id).FirstOrDefault();

            return selectedBrewery;
        }

        public void Insert(Brewery brewery)
        {
            _breweries.Add(brewery);
        }

        public void Update(Brewery brewery)
        {
            
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {

        }

        public void Dispose()
        {
            _breweries = null;
        }
    }
}