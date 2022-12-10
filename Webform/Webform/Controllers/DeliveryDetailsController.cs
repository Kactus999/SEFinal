using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webform.Models;

namespace Webform.Controllers
{
    public class DeliveryDetailsController : Controller
    {
        private DevConn db = new DevConn();

        // GET: DeliveryDetails
        public ActionResult Index()
        {
            var deliveryDetails = db.DeliveryDetails.Include(d => d.Agent).Include(d => d.Company).Include(d => d.Delivery);
            return View(deliveryDetails.ToList());
        }

        // GET: DeliveryDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryDetail deliveryDetail = db.DeliveryDetails.Find(id);
            if (deliveryDetail == null)
            {
                return HttpNotFound();
            }
            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Create
        public ActionResult Create()
        {
            ViewBag.AgentID = new SelectList(db.Agents, "AgentID", "AgentName");
            ViewBag.PID = new SelectList(db.Companies, "PID", "Pname");
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryID", "DeliveryID");
            ViewBag.Pname = new SelectList(db.Companies, "Pname", "Pname");
            return View();
        }

        // POST: DeliveryDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeliveryID,AgentID,PID,Pname,Quantity,Price")] DeliveryDetail deliveryDetail)
        {
            if (ModelState.IsValid)
            {
                db.DeliveryDetails.Add(deliveryDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AgentID = new SelectList(db.Agents, "AgentID", "AgentName", deliveryDetail.AgentID);
            ViewBag.PID = new SelectList(db.Companies, "PID", "PName", deliveryDetail.PID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryID", "DeliveryStatus", deliveryDetail.DeliveryID);
            ViewBag.Pname = new SelectList(db.Companies, "Pname", deliveryDetail.Pname);
            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryDetail deliveryDetail = db.DeliveryDetails.Find(id);
            if (deliveryDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.AgentID = new SelectList(db.Agents, "AgentID", "AgentName", deliveryDetail.AgentID);
            ViewBag.PID = new SelectList(db.Companies, "PID", "PName", deliveryDetail.PID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryID", "DeliveryStatus", deliveryDetail.DeliveryID);
            return View(deliveryDetail);
        }

        // POST: DeliveryDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeliveryID,AgentID,PID,Pname,Quantity,Price")] DeliveryDetail deliveryDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deliveryDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AgentID = new SelectList(db.Agents, "AgentID", "AgentName", deliveryDetail.AgentID);
            ViewBag.PID = new SelectList(db.Companies, "PID", "PName", deliveryDetail.PID);
            ViewBag.DeliveryID = new SelectList(db.Deliveries, "DeliveryID", "DeliveryStatus", deliveryDetail.DeliveryID);
            return View(deliveryDetail);
        }

        // GET: DeliveryDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryDetail deliveryDetail = db.DeliveryDetails.Find(id);
            if (deliveryDetail == null)
            {
                return HttpNotFound();
            }
            return View(deliveryDetail);
        }

        // POST: DeliveryDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeliveryDetail deliveryDetail = db.DeliveryDetails.Find(id);
            db.DeliveryDetails.Remove(deliveryDetail);
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
