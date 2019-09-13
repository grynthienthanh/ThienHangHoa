namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class BAO_CAO_CONG_NO
    {
        [Key]
        public int MaBCN { get; set; }
        public DateTime Thang { get; set; }

        
        public int MaKH { get; set; }

        public int? NoDau { get; set; }

        public int? NoCuoi { get; set; }

        [StringLength(200)]
        public int? PhatSinh { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
