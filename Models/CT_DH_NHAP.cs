namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class CT_DH_NHAP
    {
        [Key]
        
        public int MaCTHDN { get; set; }

        
        public int MaHDN { get; set; }

        
        public int MaMH { get; set; }

        public int? SoLuongNhap { get; set; }

        public int? ThanhTien { get; set; }
        [ForeignKey("MaHD")]
        public virtual HD_NHAP HD_NHAP { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }
    }
}
