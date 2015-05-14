using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDataCachManagement.Controllers
{
    public class OurController : Controller
    {
        //
        // GET: /Our/
        Models.OurDatabaseEntities de = new Models.OurDatabaseEntities();

        [OutputCache(Duration=180,Location=System.Web.UI.OutputCacheLocation.ServerAndClient)]
        public ActionResult Index()
        {
            var result = from p in de.PlayerTables
                         select p;
            return View(result.ToList());
        }

        //
        // GET: /Our/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Our/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Our/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Our/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Our/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Our/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Our/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
