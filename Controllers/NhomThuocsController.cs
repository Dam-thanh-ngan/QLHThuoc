using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLHieuThuoc.Models;

namespace QLHieuThuoc.Controllers
{
    public class NhomThuocsController : Controller
    {
        private QLHTDbContext db = new QLHTDbContext();

        // GET: NhomThuocs
        public ActionResult Index()
        {
            return View(db.NhomThuocs.ToList());
        }

        // GET: NhomThuocs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhomThuoc nhomThuoc = db.NhomThuocs.Find(id);
            if (nhomThuoc == null)
            {
                return HttpNotFound();
            }
            return View(nhomThuoc);
        }

        // GET: NhomThuocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhomThuocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhom,TenNhom")] NhomThuoc nhomThuoc)
        {
            if (ModelState.IsValid)
            {
                db.NhomThuocs.Add(nhomThuoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhomThuoc);
        }

        // GET: NhomThuocs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhomThuoc nhomThuoc = db.NhomThuocs.Find(id);
            if (nhomThuoc == null)
            {
                return HttpNotFound();
            }
            return View(nhomThuoc);
        }

        // POST: NhomThuocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhom,TenNhom")] NhomThuoc nhomThuoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhomThuoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhomThuoc);
        }

        // GET: NhomThuocs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhomThuoc nhomThuoc = db.NhomThuocs.Find(id);
            if (nhomThuoc == null)
            {
                return HttpNotFound();
            }
            return View(nhomThuoc);
        }

        // POST: NhomThuocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhomThuoc nhomThuoc = db.NhomThuocs.Find(id);
            db.NhomThuocs.Remove(nhomThuoc);
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
