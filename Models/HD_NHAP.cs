namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class HD_NHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HD_NHAP()
        {
            CT_DH_NHAP = new HashSet<CT_DH_NHAP>();
        }

        [Key]
        
        public int MaHDN { get; set; }

  
        public int MaNCC { get; set; }

        public int? SoHDNhap { get; set; }

        public DateTime? Ngay { get; set; }

        public int? TongTienNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_DH_NHAP> CT_DH_NHAP { get; set; }
    }
}
