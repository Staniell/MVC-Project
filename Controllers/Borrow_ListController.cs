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
    public class Borrow_ListController : Controller
    {
        private Model1 db = new Model1();

        // GET: Borrow_List
        public ActionResult Index()
        {
            var borrow_List = db.Borrow_List.Include(b => b.Book).Include(b => b.Reg_Accounts);
            return View(borrow_List.ToList());
        }

        // GET: Borrow_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow_List borrow_List = db.Borrow_List.Find(id);
            if (borrow_List == null)
            {
                return HttpNotFound();
            }
            return View(borrow_List);
        }

        // GET: Borrow_List/Create
        public ActionResult Create()
        {
            ViewBag.Book_ID = new SelectList(db.Books, "Book_ID", "Book_Name");
            ViewBag.Borrower_Name = new SelectList(db.Reg_Accounts, "Borrower_Name", "Phone_Number");
            return View();
        }

        // POST: Borrow_List/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Book_ID,Account_Created,Borrower_Name,Status,Date_Borrowed,Date_Return,Date_Paid,Fee")] Borrow_List borrow_List)
        {
            if (ModelState.IsValid)
            {
                db.Borrow_List.Add(borrow_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Book_ID = new SelectList(db.Books, "Book_ID", "Book_Name", borrow_List.Book_ID);
            ViewBag.Borrower_Name = new SelectList(db.Reg_Accounts, "Borrower_Name", "Phone_Number", borrow_List.Borrower_Name);
            return View(borrow_List);
        }

        // GET: Borrow_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow_List borrow_List = db.Borrow_List.Find(id);
            if (borrow_List == null)
            {
                return HttpNotFound();
            }
            ViewBag.Book_ID = new SelectList(db.Books, "Book_ID", "Book_Name", borrow_List.Book_ID);
            ViewBag.Borrower_Name = new SelectList(db.Reg_Accounts, "Borrower_Name", "Phone_Number", borrow_List.Borrower_Name);
            return View(borrow_List);
        }

        // POST: Borrow_List/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Book_ID,Account_Created,Borrower_Name,Status,Date_Borrowed,Date_Return,Date_Paid,Fee")] Borrow_List borrow_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(borrow_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Book_ID = new SelectList(db.Books, "Book_ID", "Book_Name", borrow_List.Book_ID);
            ViewBag.Borrower_Name = new SelectList(db.Reg_Accounts, "Borrower_Name", "Phone_Number", borrow_List.Borrower_Name);
            return View(borrow_List);
        }

        // GET: Borrow_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Borrow_List borrow_List = db.Borrow_List.Find(id);
            //Borrow_List borrow_List = db.Borrow_List.FirstOrDefault();

            if (borrow_List == null)
            {
                return HttpNotFound();
            }
            return View(borrow_List);
        }

        // POST: Borrow_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Borrow_List borrow_List = db.Borrow_List.Find(id);
            //Borrow_List borrow_List = db.Borrow_List.FirstOrDefault();
            db.Borrow_List.Remove(borrow_List);
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
