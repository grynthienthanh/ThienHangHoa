namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class HD_XUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HD_XUAT()
        {
            CT_HD_XUAT = new HashSet<CT_HD_XUAT>();
        }

        [Key]
        
        public int MaHDX { get; set; }

        
        public int MaKH { get; set; }

        
        public int SoHDX { get; set; }

        public DateTime Ngay { get; set; }

        public int? TongTien { get; set; }

        public int? PhiVanCHuyen { get; set; }

        public int? TongCong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HD_XUAT> CT_HD_XUAT { get; set; }

        public virtual KHACH_HANG KHACH_HANG { get; set; }
    }
}
