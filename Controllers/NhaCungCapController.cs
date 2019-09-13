using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using XNHH.Models;
using XNHH.Data;

namespace XNHH.Controllers
{
    public class NhaCungCapController : Controller
    {
        ApplicationDbContext _database;
        public NhaCungCapController(ApplicationDbContext db)
        {
            _database = db;
        }
        public IActionResult Index()
        {
            List<NHA_CUNG_CAP> lis = _database.NHA_CUNG_CAP.ToList();
            return View(lis);
        }
    
        public IActionResult Edit(int id)
        {
            var ncc = _database.NHA_CUNG_CAP.FirstOrDefault(ch => ch.MaNCC == id);
            NHA_CUNG_CAP nccViewModel = new NHA_CUNG_CAP()
            {
                MaNCC = ncc.MaNCC,
                TenNCC = ncc.TenNCC,
                DiaChi = ncc.DiaChi

            };
            return View(nccViewModel);          
        }
        [HttpPost]
        public IActionResult Edit(int id, NHA_CUNG_CAP nccVM)
        {
            var ncc = _database.NHA_CUNG_CAP.FirstOrDefault(k => k.MaNCC == id);
            ncc.TenNCC = nccVM.TenNCC;
            ncc.DiaChi = nccVM.DiaChi;
            _database.SaveChanges();
            return RedirectToAction("Index", "NhaCungCap"); ;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(NHA_CUNG_CAP newNhaCC)
        {
            if (ModelState.IsValid)
            {       
                
                _database.NHA_CUNG_CAP.Add(newNhaCC);
                _database.SaveChanges();
                return RedirectToAction("Index", "NhaCungCap");
                
            }
            else
            {
                return View(newNhaCC);
            }
        }
        public IActionResult Delete(int id)
        {
            _database.NHA_CUNG_CAP.Remove(_database.NHA_CUNG_CAP.Find(id));
            _database.SaveChanges();
            return Ok();
        }
    }
}