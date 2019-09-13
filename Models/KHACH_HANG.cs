namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class KHACH_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACH_HANG()
        {
            BAO_CAO_CONG_NO = new HashSet<BAO_CAO_CONG_NO>();
            HD_XUAT = new HashSet<HD_XUAT>();
            PHIEU_THU_TIEN = new HashSet<PHIEU_THU_TIEN>();
        }

        [Key]
        
        public int MaKH { get; set; }

        public string TenKH { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }
        public decimal TienNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAO_CAO_CONG_NO> BAO_CAO_CONG_NO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD_XUAT> HD_XUAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEU_THU_TIEN> PHIEU_THU_TIEN { get; set; }
    }
}
