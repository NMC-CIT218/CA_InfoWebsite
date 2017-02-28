using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_InfoWebsite.Models;
using System.IO;
using System.Xml.Serialization;
using System.Web;

namespace CA_InfoWebsite.DAL
{
    public class BreweryXmlDataService : IBreweryDataService, IDisposable
    {
        public List<Brewery> Read()
        {
            // a Breweries model is defined to pass a type to the XmlSerializer object 
            Breweries breweriesObject;

            // initialize a FileStream object for reading
            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();
            StreamReader sReader = new StreamReader(xmlFilePath);

            // initialize an XML seriailizer object
            XmlSerializer deserializer = new XmlSerializer(typeof(Breweries));

            using (sReader)
            {
                // deserialize the XML data set into a generic object
                object xmlObject = deserializer.Deserialize(sReader);

                // cast the generic object to the list class
                breweriesObject = (Breweries)xmlObject;
            }

            return breweriesObject.breweries;
        }

        public void Write(List<Brewery> breweries)
        {
            // initialize a FileStream object for reading
            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();
            StreamWriter sWriter = new StreamWriter(xmlFilePath, false);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Brewery>), new XmlRootAttribute("Breweries"));

            using (sWriter)
            {
                serializer.Serialize(sWriter, breweries);
            }
        }

        public void Dispose()
        {
            // set resources to be cleaned up
        }
    }
}