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
    public class BaoCaoTonController : Controller
    {
        ApplicationDbContext _database;
        public BaoCaoTonController(ApplicationDbContext db)
        {
            _database = db;
        }
        public IActionResult Index()
        {
            List<BAO_CAO_TON> lis = _database.BAO_CAO_TON.ToList();
            return View(lis);
        }

        public IActionResult Add()
        {
            BAO_CAO_TON nccVMD = new BAO_CAO_TON();
            ViewData["ViewIDNhaCungCap"] = new SelectList(_database.NHA_CUNG_CAP.ToList(), "MaNCC", "TenNCC");
            BAO_CAO_TON matHangVMD = new BAO_CAO_TON();
            ViewData["MaMatHang"] = new SelectList(_database.MAT_HANG.ToList(), "MaMH", "TenMH");
            return View(nccVMD);
            

        }
        [HttpPost]
        public IActionResult Add(BAO_CAO_TON newbcTon)
        {
            if (ModelState.IsValid)
            {

                newbcTon.PhatSinh = newbcTon.TonDau - newbcTon.TonCuoi;
                _database.BAO_CAO_TON.Add(newbcTon);
                _database.SaveChanges();
                return RedirectToAction("Index", "BaoCaoTon");
            }
            else
            {
                return View(newbcTon);
            }
        }
        public IActionResult Edit(int id)
        {
            var bcTon = _database.BAO_CAO_TON.FirstOrDefault(ch => ch.MaBCTon == id);
            BAO_CAO_TON bcTonViewModel = new BAO_CAO_TON()
            {
                Thang=bcTon.Thang,
                MaMH=bcTon.MaMH,
                MANCC=bcTon.MANCC,
                TonDau=bcTon.TonDau,
                TonCuoi=bcTon.TonCuoi,
                PhatSinh=bcTon.PhatSinh
            };
            return View(bcTonViewModel);
        }
        [HttpPost]
        public IActionResult Edit(int id, BAO_CAO_TON bctonVM)
        {
            var bcTon = _database.BAO_CAO_TON.FirstOrDefault(k => k.MaBCTon == id);
            bcTon.Thang = bcTon.Thang;
            bcTon.MaMH = bctonVM.MaMH;
            bcTon.MANCC = bcTon.MANCC;
            bcTon.TonDau = bcTon.TonDau;
            bcTon.TonCuoi = bcTon.TonCuoi;
            _database.SaveChanges();
            return RedirectToAction("Index", "BaoCaoTon");
        }
        public IActionResult Delete(int id)
        {
            _database.BAO_CAO_TON.Remove(_database.BAO_CAO_TON.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}