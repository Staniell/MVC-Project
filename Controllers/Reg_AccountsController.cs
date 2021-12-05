using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mp.Models;

namespace mp.Controllers
{
    public class Reg_AccountsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Reg_Accounts
        public ActionResult Index()
        {
            return View(db.Reg_Accounts.ToList());
        }

        // GET: Reg_Accounts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg_Accounts reg_Accounts = db.Reg_Accounts.Find(id);
            if (reg_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(reg_Accounts);
        }

        // GET: Reg_Accounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reg_Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Borrower_Name,Phone_Number,Borrower_Email,Borrower_Password,Account_Created")] Reg_Accounts reg_Accounts)
        {
            if (ModelState.IsValid)
            {
                db.Reg_Accounts.Add(reg_Accounts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reg_Accounts);
        }

        // GET: Reg_Accounts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg_Accounts reg_Accounts = db.Reg_Accounts.Find(id);
            if (reg_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(reg_Accounts);
        }

        // POST: Reg_Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Borrower_Name,Phone_Number,Borrower_Email,Borrower_Password,Account_Created")] Reg_Accounts reg_Accounts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reg_Accounts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reg_Accounts);
        }

        // GET: Reg_Accounts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reg_Accounts reg_Accounts = db.Reg_Accounts.Find(id);
            if (reg_Accounts == null)
            {
                return HttpNotFound();
            }
            return View(reg_Accounts);
        }

        // POST: Reg_Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Reg_Accounts reg_Accounts = db.Reg_Accounts.Find(id);
            db.Reg_Accounts.Remove(reg_Accounts);
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
