using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_InfoWebsite.Models;

namespace CA_InfoWebsite.DAL
{
    public class BreweryRepository : IBrewryRepository, IDisposable
    {
        public IEnumerable<Brewery> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Brewery SelectOne(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Brewery brewery)
        {
            throw new NotImplementedException();
        }

        public void Update(Brewery brewery)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}