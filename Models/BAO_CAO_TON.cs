namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    public partial class BAO_CAO_TON
    {
        [Key]
        public int MaBCTon { get; set; }
        public DateTime Thang { get; set; }

        
        public int MaMH { get; set; }

        
        public int MANCC { get; set; }

        public int? TonDau { get; set; }

        public int? TonCuoi { get; set; }

        [StringLength(200)]
        public int? PhatSinh { get; set; }

        public virtual NHA_CUNG_CAP NHA_CUNG_CAP { get; set; }

        public virtual MAT_HANG MAT_HANG { get; set; }
    }
}
