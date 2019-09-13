using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using XNHH.Data;
using XNHH.Models;


namespace XNHH.Controllers
{
    public class KhachHangController : Controller
    {
        ApplicationDbContext _database;
        public KhachHangController(ApplicationDbContext db)
        {
            _database = db;

        }
        public IActionResult Index()
        {
            List<KHACH_HANG> lis = _database.KHACH_HANG.ToList();
            return View(lis);
        }
        public IActionResult Add()
        {
            
            return View();

        }
        [HttpPost]
        public IActionResult Add(KHACH_HANG newCustomer)
        {
            if (ModelState.IsValid)
            {
                _database.KHACH_HANG.Add(newCustomer);
                _database.SaveChanges();
                return RedirectToAction("Index", "KhachHang");
            }
            else
            {
                return View(newCustomer);
            }
        }
        public IActionResult Edit(int id)
        {
            var customer = _database.KHACH_HANG.FirstOrDefault(ch => ch.MaKH == id);
            KHACH_HANG customerViewModel = new KHACH_HANG()
            {
                TenKH = customer.TenKH,
                SDT = customer.SDT,
                DiaChi = customer.DiaChi,
                TienNo = customer.TienNo,
            };
            return View(customerViewModel);

        }

        [HttpPost]
        public IActionResult Edit(int id,KHACH_HANG khachHangVM)
        {
            var khachHang = _database.KHACH_HANG.FirstOrDefault(k => k.MaKH == id);
            khachHang.TenKH = khachHangVM.TenKH;
            khachHang.SDT = khachHangVM.SDT;
            khachHang.DiaChi = khachHang.DiaChi;
            khachHang.TienNo = khachHang.TienNo;
            _database.SaveChanges();
            return RedirectToAction("Index", "KhachHang");
        }
        [HttpPost]
        public IActionResult TruTien(PHIEU_THU_TIEN soTienThu)
        {
            var khachHang = _database.KHACH_HANG.FirstOrDefault(k => k.MaKH == soTienThu.MaKH);
            khachHang.TienNo = Decimal.ToInt32(khachHang.TienNo) - soTienThu.SoTienThu;
            _database.SaveChanges();
            return Redirect("~/KhachHang/Index");
        }


        public IActionResult Delte(int id)
        {
            _database.KHACH_HANG.Remove(_database.KHACH_HANG.Find(id));
            _database.SaveChanges();
            return Ok();
        }
        //public IActionResult BackToHomePage()
        //{
        //    return RedirectToAction{"Index","KhachHang"};
        //}
    }
}