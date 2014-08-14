using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MGXAdminConsole.Models;

namespace MGXAdminConsole.Controllers
{
    public class MGXAdminConsoleUserRoleController : Controller
    {
        private MGXAdminConsoleUser db = new MGXAdminConsoleUser();

        // GET: /MGXAdminComsoleUserRole/
        public ActionResult Index()
        {
            return View(db.AspNetRoles.ToList());
        }

        // GET: /MGXAdminComsoleUserRole/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRole aspnetrole = db.AspNetRoles.Find(id);
            if (aspnetrole == null)
            {
                return HttpNotFound();
            }
            return View(aspnetrole);
        }

        // GET: /MGXAdminComsoleUserRole/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /MGXAdminComsoleUserRole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name")] AspNetRole aspnetrole)
        {
            if (ModelState.IsValid)
            {
                db.AspNetRoles.Add(aspnetrole);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aspnetrole);
        }

        // GET: /MGXAdminComsoleUserRole/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRole aspnetrole = db.AspNetRoles.Find(id);
            if (aspnetrole == null)
            {
                return HttpNotFound();
            }
            return View(aspnetrole);
        }

        // POST: /MGXAdminComsoleUserRole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name")] AspNetRole aspnetrole)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aspnetrole).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aspnetrole);
        }

        // GET: /MGXAdminComsoleUserRole/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AspNetRole aspnetrole = db.AspNetRoles.Find(id);
            if (aspnetrole == null)
            {
                return HttpNotFound();
            }
            return View(aspnetrole);
        }

        // POST: /MGXAdminComsoleUserRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AspNetRole aspnetrole = db.AspNetRoles.Find(id);
            db.AspNetRoles.Remove(aspnetrole);
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
