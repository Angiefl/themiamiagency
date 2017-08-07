using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using themiamiagency.Models;

namespace themiamiagency.API.Controllers
{
    public class AutoQuoteController : ApiController
    {
        private MyDbContext db = new MyDbContext();

        // GET api/AutoQuote
        public IQueryable<AutoQuote> GetAutoQuotes()
        {
            return db.AutoQuotes;
        }

        // GET api/AutoQuote/5
        [ResponseType(typeof(AutoQuote))]
        public IHttpActionResult GetAutoQuote(int id)
        {
            AutoQuote autoquote = db.AutoQuotes.Find(id);
            if (autoquote == null)
            {
                return NotFound();
            }

            return Ok(autoquote);
        }

        // PUT api/AutoQuote/5
        public IHttpActionResult PutAutoQuote(int id, AutoQuote autoquote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != autoquote.Id)
            {
                return BadRequest();
            }

            db.Entry(autoquote).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoQuoteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST api/AutoQuote
        [ResponseType(typeof(AutoQuote))]
        public IHttpActionResult PostAutoQuote(AutoQuote autoquote)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AutoQuotes.Add(autoquote);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = autoquote.Id }, autoquote);
        }

        // DELETE api/AutoQuote/5
        [ResponseType(typeof(AutoQuote))]
        public IHttpActionResult DeleteAutoQuote(int id)
        {
            AutoQuote autoquote = db.AutoQuotes.Find(id);
            if (autoquote == null)
            {
                return NotFound();
            }

            db.AutoQuotes.Remove(autoquote);
            db.SaveChanges();

            return Ok(autoquote);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutoQuoteExists(int id)
        {
            return db.AutoQuotes.Count(e => e.Id == id) > 0;
        }
    }
}