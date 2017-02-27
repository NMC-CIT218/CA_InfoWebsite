using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace CA_InfoWebsite.Models
{
    [XmlRoot("Breweries")]
    public class Breweries
    {
        [XmlElement("Brewery")]
        public IEnumerable<Brewery> breweries;
    }
}