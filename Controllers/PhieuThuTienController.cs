using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XNHH.Models;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using XNHH.Data;

namespace XNHH.Controllers
{
    public class PhieuThuTienController : Controller
    {
        ApplicationDbContext _database;
        public PhieuThuTienController(ApplicationDbContext db)
        {
            _database = db;

        }
        public IActionResult Index()
        {
            List<PHIEU_THU_TIEN> lis = _database.PHIEU_THU_TIEN.ToList();
            return View(lis);
        }
        public IActionResult Add()
        {
            KHACH_HANG khachHangVMD = new KHACH_HANG();
            ViewData["MaKhachHang"] = new SelectList(_database.KHACH_HANG.ToList(), "MaKH", "TenKH");
            return View();

        }
        [HttpPost]
        public IActionResult Add(PHIEU_THU_TIEN newPhieu)
        {
            if (ModelState.IsValid)
            {
                _database.PHIEU_THU_TIEN.Add(newPhieu);
                _database.SaveChanges();
                return RedirectToAction("Index", "PhieuThuTien");
            }
            else
            {
                return View(newPhieu);
            }
        }
        public IActionResult Edit(int id)
        {
            var phieu = _database.PHIEU_THU_TIEN.FirstOrDefault(ch => ch.MaPTT == id);
            PHIEU_THU_TIEN phieuViewModel = new PHIEU_THU_TIEN()
            {
                MaKH = phieu.MaKH,
                SoTienThu = phieu.SoTienThu,
                NgayThuTien = phieu.NgayThuTien,
                
            };
            return View(phieuViewModel);

        }

        [HttpPost]
        public IActionResult Edit(int id, PHIEU_THU_TIEN phieuVM)
        {
            var phieuthu = _database.PHIEU_THU_TIEN.FirstOrDefault(k => k.MaPTT == id);
            phieuthu.MaKH = phieuVM.MaKH;
            phieuthu.SoTienThu = phieuVM.SoTienThu;
            phieuthu.NgayThuTien = phieuVM.NgayThuTien;
            _database.SaveChanges();
            return RedirectToAction("Index", "PhieuThu");
        }


        public IActionResult Delete(int id)
        {
            _database.PHIEU_THU_TIEN.Remove(_database.PHIEU_THU_TIEN.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}