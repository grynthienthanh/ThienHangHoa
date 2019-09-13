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
    public class BaoCaoNoController : Controller
    {
        ApplicationDbContext _database;
        public BaoCaoNoController(ApplicationDbContext db)
        {
            _database = db;
        }
        public IActionResult Index()
        {
            List<BAO_CAO_CONG_NO> lis = _database.BAO_CAO_CONG_NO.ToList();
            return View(lis);
        }
        
        public IActionResult Add()
        {
            BAO_CAO_CONG_NO khachHangVMD = new BAO_CAO_CONG_NO();
            ViewData["MaKhachHang"] = new SelectList(_database.KHACH_HANG.ToList(), "MaKH", "TenKH");
            return View(khachHangVMD);
        }
        [HttpPost]
        public IActionResult Add(BAO_CAO_CONG_NO newbcNo)
        {
            if (ModelState.IsValid)
            {
                newbcNo.PhatSinh = newbcNo.NoDau - newbcNo.NoCuoi;
                _database.BAO_CAO_CONG_NO.Add(newbcNo);
                _database.SaveChanges();
                return RedirectToAction("Index", "BaoCaoNo");
            }
            else
            {
                return View(newbcNo);
            }
        }
        public IActionResult Edit(int id)
        {
            var bcNo = _database.BAO_CAO_CONG_NO.FirstOrDefault(ch => ch.MaBCN== id);
            BAO_CAO_CONG_NO bcNoViewModel = new BAO_CAO_CONG_NO()
            {
                Thang = bcNo.Thang,
                NoDau=bcNo.NoDau,
                NoCuoi=bcNo.NoCuoi,
                PhatSinh=bcNo.PhatSinh,
            };
            return View(bcNoViewModel);
        }
        [HttpPost]
        public IActionResult Edit(int id,BAO_CAO_CONG_NO bcnoVM)
        {
            var bcNo= _database.BAO_CAO_CONG_NO.FirstOrDefault(k => k.MaBCN == id);
            bcNo.Thang = bcnoVM.Thang;
            bcNo.NoDau = bcnoVM.NoCuoi;
            bcNo.NoCuoi = bcnoVM.NoCuoi;
            bcNo.PhatSinh = bcnoVM.PhatSinh;
            _database.SaveChanges();
            return RedirectToAction("Index", "BaoCaoNo");
        } 
        public IActionResult Delete(int id)
        {
            _database.BAO_CAO_CONG_NO.Remove(_database.BAO_CAO_CONG_NO.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}
    