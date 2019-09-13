namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class NCC_HANG_NHAP
    {
        [Key]
        
        public int MaNCCHangNhap { get; set; }

        
        public int MaMH { get; set; }

        [StringLength(5)]
        public int MaNCC { get; set; }

        public int? SoLuongTon { get; set; }

        public int? DonGiaNhap { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }
    }
}
