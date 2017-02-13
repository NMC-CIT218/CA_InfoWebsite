﻿using CA_InfoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA_InfoWebsite.DAL
{
    public static class InitializeSeedData
    {
        public static IEnumerable<Brewery> GetAllBreweries()
        {
            IList<Brewery> breweries = new List<Brewery>();

            breweries.Add(new Brewery
            {
                Id = 1,
                Name = "Acoustic Tap Room",
                Address = "119 Maple St",
                City = "Traverse City",
                State = "MI",
                Zip = "49684",
                Phone = "(231)883-2012",
                URL = "drinkacoustic.com"
            });

            breweries.Add(new Brewery
            {
                Id = 2,
                Name = "Beggars Brewery",
                Address = "4177 Village Park Dr. Suite C",
                City = "Traverse City",
                State = "MI",
                Zip = "49684",
                Phone = "(555)555-5555",
                URL = "beggarsbrewery.com"
            });

            breweries.Add(new Brewery
            {
                Id = 3,
                Name = "Big Cat Brewing Company",
                Address = "8699 Good Harbor Trail",
                City = "Cedar",
                State = "MI",
                Zip = "49621",
                Phone = "(231)228-2282",
                URL = "cedarrusticinn.com"
            });

            return breweries;
        }
    }
}