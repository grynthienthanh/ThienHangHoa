namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class MAT_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MAT_HANG()
        {
            BAO_CAO_TON = new HashSet<BAO_CAO_TON>();
            CT_DH_NHAP = new HashSet<CT_DH_NHAP>();
            CT_HD_XUAT = new HashSet<CT_HD_XUAT>();
            NCC_HANG_NHAP = new HashSet<NCC_HANG_NHAP>();
        }

        [Key]
        
        public int MaMH { get; set; }

        [StringLength(70)]
        public string TenMH { get; set; }

        public int? SoLuongTon { get; set; }

        public int? DonGiaXuat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAO_CAO_TON> BAO_CAO_TON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DH_NHAP> CT_DH_NHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HD_XUAT> CT_HD_XUAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NCC_HANG_NHAP> NCC_HANG_NHAP { get; set; }
    }
}
