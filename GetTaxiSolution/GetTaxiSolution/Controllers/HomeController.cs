using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using GetTaxiSolution.Models;

namespace GetTaxiSolution.Controllers
{
    /// <summary>
    /// Controller for TEST purposes !!
    /// </summary>
    public class HomeController : ApiController
    {
        private TaxiAppDbContext db = new TaxiAppDbContext();

        // GET api/Home
        public IEnumerable<Driver> GetTaxiDrivers()
        {
            return db.Drivers.AsEnumerable();
        }

        // GET api/Home/5
        public Driver GetTaxiDriver(int id)
        {
            Driver taxidriver = db.Drivers.Find(id);
            if (taxidriver == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return taxidriver;
        }

        // PUT api/Home/5
        public HttpResponseMessage PutTaxiDriver(int id, Driver taxidriver)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            if (id != taxidriver.DriverID)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            db.Entry(taxidriver).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST api/Home
        public HttpResponseMessage PostTaxiDriver(Driver taxidriver)
        {
            if (ModelState.IsValid)
            {
                db.Drivers.Add(taxidriver);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, taxidriver);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = taxidriver.DriverID}));
                return response;
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }

        // DELETE api/Home/5
        public HttpResponseMessage DeleteTaxiDriver(int id)
        {
            Driver taxidriver = db.Drivers.Find(id);
            if (taxidriver == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Drivers.Remove(taxidriver);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }

            return Request.CreateResponse(HttpStatusCode.OK, taxidriver);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}