using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace XNHH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<BAO_CAO_CONG_NO> BAO_CAO_CONG_NO { get; set; }
        public virtual DbSet<BAO_CAO_TON> BAO_CAO_TON { get; set; }
        public virtual DbSet<CT_DH_NHAP> CT_DH_NHAP { get; set; }
        public virtual DbSet<CT_HD_XUAT> CT_HD_XUAT { get; set; }
        public virtual DbSet<HD_NHAP> HD_NHAP { get; set; }
        public virtual DbSet<HD_XUAT> HD_XUAT { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<MAT_HANG> MAT_HANG { get; set; }
        public virtual DbSet<NCC_HANG_NHAP> NCC_HANG_NHAP { get; set; }
        public virtual DbSet<NHA_CUNG_CAP> NHA_CUNG_CAP { get; set; }
        public virtual DbSet<PHIEU_THU_TIEN> PHIEU_THU_TIEN { get; set; }
    }
}
