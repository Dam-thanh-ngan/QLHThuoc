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
    public class ChiTietNhapsController : Controller
    {
        private QLHTDbContext db = new QLHTDbContext();

        // GET: ChiTietNhaps
        public ActionResult Index()
        {
            return View(db.ChiTietNhaps.ToList());
        }

        // GET: ChiTietNhaps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietNhap chiTietNhap = db.ChiTietNhaps.Find(id);
            if (chiTietNhap == null)
            {
                return HttpNotFound();
            }
            return View(chiTietNhap);
        }

        // GET: ChiTietNhaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietNhaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "STT,MaPhieuNhap,MaThuoc,MaNCC,SoLuong,NgayNhap")] ChiTietNhap chiTietNhap)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietNhaps.Add(chiTietNhap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chiTietNhap);
        }

        // GET: ChiTietNhaps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietNhap chiTietNhap = db.ChiTietNhaps.Find(id);
            if (chiTietNhap == null)
            {
                return HttpNotFound();
            }
            return View(chiTietNhap);
        }

        // POST: ChiTietNhaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "STT,MaPhieuNhap,MaThuoc,MaNCC,SoLuong,NgayNhap")] ChiTietNhap chiTietNhap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietNhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chiTietNhap);
        }

        // GET: ChiTietNhaps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietNhap chiTietNhap = db.ChiTietNhaps.Find(id);
            if (chiTietNhap == null)
            {
                return HttpNotFound();
            }
            return View(chiTietNhap);
        }

        // POST: ChiTietNhaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietNhap chiTietNhap = db.ChiTietNhaps.Find(id);
            db.ChiTietNhaps.Remove(chiTietNhap);
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
