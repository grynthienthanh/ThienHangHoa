namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class CT_HD_XUAT
    {
        [Key]
        
        public int MaCTHDX { get; set; }

        
        public int MaHDX { get; set; }

        
        public int MaMH { get; set; }

        public int? SoLuongXuat { get; set; }

        public int? ThanhTien { get; set; }

        public virtual HD_XUAT HD_XUAT { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }
    }
}
