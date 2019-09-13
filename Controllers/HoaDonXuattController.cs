using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using XNHH.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using XNHH.Data;

namespace XNHH.Controllers
{
    public class HoaDonXuattController : Controller
    {
        ApplicationDbContext _database;
        public HoaDonXuattController(ApplicationDbContext db)
        {
            _database = db;
        }
        public IActionResult Index()
        {
            List<HD_XUAT> lis = _database.HD_XUAT.ToList();
            return View(lis);
        }
        public IActionResult Add()
        {
            KHACH_HANG khachHangVMD = new KHACH_HANG();
            ViewData["MaKhachHang"] = new SelectList(_database.KHACH_HANG.ToList(), "MaKH", "TenKH");
            return View();
        }
        [HttpPost]
        public IActionResult Add(HD_XUAT newBillOut)
        {
            if (ModelState.IsValid)
            {
                newBillOut.TongCong = newBillOut.PhiVanCHuyen + newBillOut.TongTien;
                _database.HD_XUAT.Add(newBillOut);
                _database.SaveChanges();
                return RedirectToAction("Index", "HoaDonXuatt");
            }
            else
            {
                return View(newBillOut);
            }
        }
        public IActionResult Edit()
         {
                return View();
         }
        [HttpPost]
        public IActionResult Edit(int id)
        {
            var billOut = _database.HD_XUAT.FirstOrDefault(ch => ch.MaHDX == id);
            HD_XUAT billoutViewModel = new HD_XUAT()
            {
                MaHDX = billOut.MaHDX,
                MaKH = billOut.MaKH,
              
                Ngay=billOut.Ngay,
                TongTien=billOut.TongTien,
                PhiVanCHuyen=billOut.PhiVanCHuyen,
                TongCong=billOut.TongCong,
            };
            return View(billoutViewModel);
        }
        public IActionResult Delete(int id)
        {
            _database.HD_XUAT.Remove(_database.HD_XUAT.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}