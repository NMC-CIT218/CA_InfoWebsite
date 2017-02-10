using CA_InfoWebsite.DAL;
using CA_InfoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CA_InfoWebsite.Controllers
{
    public class BreweryController : Controller
    {

        public ActionResult Index()
        {
            BreweryRepository breweryRepository = new BreweryRepository();
            IEnumerable<Brewery> breweries;

            using (breweryRepository)
            {
                breweries = breweryRepository.SelectAll();
            }

            return View(breweries);
        }


        public ActionResult Details(int id)
        {
            BreweryRepository breweryRepository = new BreweryRepository();
            Brewery brewery = new Brewery();

            using (breweryRepository)
            {
                brewery = breweryRepository.SelectOne(id);
            }

            return View(brewery);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create(Brewery brewery)
        {
            try
            {
                BreweryRepository breweryRepository = new BreweryRepository();

                using (breweryRepository)
                {
                    breweryRepository.Insert(brewery);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            BreweryRepository breweryRepository = new BreweryRepository();
            Brewery brewery = new Brewery();

            using (breweryRepository)
            {
                brewery = breweryRepository.SelectOne(id);
            }

            return View(brewery);
        }


        [HttpPost]
        public ActionResult Edit(int id, Brewery brewery)
        {
            try
            {
                BreweryRepository breweryRepository = new BreweryRepository();

                using (breweryRepository)
                {
                    breweryRepository.Update(id, brewery);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            BreweryRepository breweryRepository = new BreweryRepository();
            Brewery brewery = new Brewery();

            using (breweryRepository)
            {
                brewery = breweryRepository.SelectOne(id);
            }

            return View(brewery);
        }


        [HttpPost]
        public ActionResult Delete(int id, Brewery brewery)
        {
            try
            {
                BreweryRepository breweryRepository = new BreweryRepository();

                using (breweryRepository)
                {
                    breweryRepository.Delete(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }
    }
}
