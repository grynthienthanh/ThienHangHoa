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
    public class HoaDonNhapController : Controller
    {
        ApplicationDbContext _database;
        public HoaDonNhapController(ApplicationDbContext db)
        {   
            _database = db;
        }
        public IActionResult Index()
        {
            List<HD_NHAP> lis = _database.HD_NHAP.ToList();
            return View(lis);
        }
        [HttpPost]
        public IActionResult Add(HD_NHAP newBillIn)
        {
            if (ModelState.IsValid)
            {

                _database.HD_NHAP.Add(newBillIn);
                _database.SaveChanges();
                return RedirectToAction("Index", "HoaDonNhap");
            }
            else
            {
                return View(newBillIn);
            }
        }
        
        public IActionResult Add()
        {
            HD_NHAP maNCC = new HD_NHAP();
            ViewData["ViewIDNhaCungCap"] = new SelectList(_database.NHA_CUNG_CAP.ToList(), "MaNCC", "TenNCC");
            return View(maNCC);
        }
        
        public IActionResult Edit(int id)
        {
            var hdn = _database.HD_NHAP.FirstOrDefault(ch => ch.MaHDN == id);
            HD_NHAP hdnViewModel = new HD_NHAP()
            {
                MaNCC = hdn.MaNCC,
                
                Ngay = hdn.Ngay,
                TongTienNhap=hdn.TongTienNhap

            };
            return View(hdnViewModel);
        }
        [HttpPost]
        public IActionResult Edit(int id,HD_NHAP hdnVM)
        {
            var hdn = _database.HD_NHAP.FirstOrDefault(ch => ch.MaHDN==id);
            hdn.MaNCC = hdnVM.MaNCC;
            
            hdn.Ngay = hdnVM.Ngay;
            hdn.TongTienNhap = hdnVM.TongTienNhap;
            _database.SaveChanges();
            return RedirectToAction("Index", "HoaDonNhap");
        }
       

        public IActionResult Delete(int id)
        {
            _database.HD_NHAP.Remove(_database.HD_NHAP.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}