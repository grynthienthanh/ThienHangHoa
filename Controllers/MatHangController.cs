using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XNHH.Models;
using WebApplication1.Models;
using XNHH.Data;

namespace XNHH.Controllers
{
    public class MatHangController : Controller
    {
        ApplicationDbContext _database;
        public MatHangController(ApplicationDbContext db)
        {
            _database = db;

        }
        public IActionResult Index()
        {
            List<MAT_HANG> lis = _database.MAT_HANG.ToList();
            return View(lis);
        }
        public IActionResult Add()
        {

            return View();

        }
        [HttpPost]
        public IActionResult Add(MAT_HANG newHang)
        {
            if (ModelState.IsValid)
            {
                _database.MAT_HANG.Add(newHang);
                _database.SaveChanges();
                return RedirectToAction("Index", "MatHang");
            }
            else
            {
                return View(newHang);
            }
        }
        public IActionResult Edit(int id)
        {
            var hang = _database.MAT_HANG.FirstOrDefault(ch => ch.MaMH == id);
            MAT_HANG hangViewModel = new MAT_HANG()
            {
                TenMH = hang.TenMH,
                SoLuongTon = hang.SoLuongTon,
                DonGiaXuat = hang.DonGiaXuat,

            };
            return View(hangViewModel);

        }

        [HttpPost]
        public IActionResult Edit(int id, MAT_HANG hangVM)
        {
            var hang = _database.MAT_HANG.FirstOrDefault(k => k.MaMH == id);
            hang.TenMH = hangVM.TenMH;
            hang.SoLuongTon = hangVM.SoLuongTon;
            hang.DonGiaXuat = hangVM.DonGiaXuat;
            _database.SaveChanges();
            return RedirectToAction("Index", "MatHang");
        }


        public IActionResult Delete(int id)
        {
            _database.MAT_HANG.Remove(_database.MAT_HANG.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}