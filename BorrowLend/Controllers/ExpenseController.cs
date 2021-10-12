using BorrowLend.Data;
using BorrowLend.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BorrowLend.Models;

namespace BorrowLend.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> obj = _db.Expenses;
            return View(obj);
        }

        public IActionResult Create()
        {
            ExpenseVM ExpenseVM = new ExpenseVM();
            return View(ExpenseVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpenseVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expenses.Add(obj.expense);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }

        public IActionResult Update(int? id)
        {
            var obj = _db.Expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            _db.Expenses.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var currItem = this._db.Expenses.FirstOrDefault(i => i.Id == id);
            if (currItem == null)
            {
                return NotFound();
            }
            this._db.Expenses.Remove(currItem);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
