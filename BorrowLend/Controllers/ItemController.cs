using BorrowLend.Data;
using BorrowLend.Models;
using BorrowLend.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowLend.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> obj = _db.Items1;
            return View(obj);
        }

        public IActionResult Create()
        {
            ItemVM itemVM = new ItemVM();
            return View(itemVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ItemVM obj)
        {
            if(ModelState.IsValid)
            {
            _db.Items1.Add(obj.item);
            _db.SaveChanges();
            return RedirectToAction("Index");

            }
            return View(obj);
        }

        public IActionResult Update(int?id)
        {
            var obj = _db.Items1.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Item obj)
        {
            if(obj == null)
            {
                return NotFound();
            }
            _db.Items1.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int?id)
        {
            var currItem = this._db.Items1.FirstOrDefault(i => i.Id == id);
            if(currItem == null)
            {
                return NotFound();
            }
            this._db.Items1.Remove(currItem);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
