namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class PHIEU_THU_TIEN
    {
        [Key]
        
        public int MaPTT { get; set; }

        
        public int MaKH { get; set; }

        public int SoTienThu { get; set; }
        

        public DateTime? NgayThuTien { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
