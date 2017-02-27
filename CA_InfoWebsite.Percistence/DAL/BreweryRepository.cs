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
            //(from brewery in _breweries
            // where brewery.Id == id
            // select brewery).FirstOrDefault();

            Brewery selectedBrewery = _breweries.Where(p => p.Id == id).FirstOrDefault();

            return selectedBrewery;
        }

        public void Insert(Brewery brewery)
        {
            _breweries.Add(brewery);
        }

        public void Update(Brewery UpdateBrewery)
        {
            var oldBrewery = _breweries.Where(b => b.Id == UpdateBrewery.Id).FirstOrDefault();

            if (oldBrewery != null)
            {
                _breweries.Remove(oldBrewery);
                _breweries.Add(UpdateBrewery);
            }
        }
        public void Delete(int id)
        {
            var brewery = _breweries.Where(b => b.Id == id).FirstOrDefault();
            if (brewery != null)
            {
                _breweries.Remove(brewery);
            }
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