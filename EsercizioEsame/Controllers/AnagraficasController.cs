using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EsercizioEsame.Models;

namespace EsercizioEsame.Controllers
{
    public class AnagraficasController : Controller
    {
        private EsameContext db = new EsameContext();

        // GET: Anagraficas
        public ActionResult Index()
        {
            return View(db.Anagraficas.ToList());
        }

        // GET: Anagraficas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagraficas.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // GET: Anagraficas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anagraficas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnagraficaId,Nome,Cognome,Indirizzo,Telefono,IsCliente,IsFornitore,IsInterno,CodiceAnagrafica")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.Anagraficas.Add(anagrafica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anagrafica);
        }

        // GET: Anagraficas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagraficas.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagraficas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnagraficaId,Nome,Cognome,Indirizzo,Telefono,IsCliente,IsFornitore,IsInterno,CodiceAnagrafica")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anagrafica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anagrafica);
        }

        // GET: Anagraficas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.Anagraficas.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagraficas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anagrafica anagrafica = db.Anagraficas.Find(id);
            db.Anagraficas.Remove(anagrafica);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
