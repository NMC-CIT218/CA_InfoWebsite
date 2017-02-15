using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CA_InfoWebsite.Models;
using System.IO;
using System.Xml.Serialization;

namespace CA_InfoWebsite.DAL
{
    public class BreweryXmlDataService : IBreweryDataService
    {
        public IEnumerable<Brewery> Read()
        {
            // a Breweries model is defined to pass a type to the XmlSerializer object 
            Breweries breweriesObject;

            // initialize a FileStream object for reading
            StreamReader sReader = new StreamReader(DataSettings.dataFilePath);

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

        public void Write(IEnumerable<Brewery> breweries)
        {
            // initialize a FileStream object for reading
            StreamWriter sWriter = new StreamWriter(DataSettings.dataFilePath, false);

            XmlSerializer serializer = new XmlSerializer(typeof(Breweries), new XmlRootAttribute("Breweries"));

            using (sWriter)
            {
                serializer.Serialize(sWriter, breweries);
            }
        }
    }
}