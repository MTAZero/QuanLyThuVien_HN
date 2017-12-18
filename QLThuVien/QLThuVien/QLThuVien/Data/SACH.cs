namespace QLThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETMUONs = new HashSet<CHITIETMUON>();
        }

        public int ID { get; set; }

        public string MASACH { get; set; }

        public string TEN { get; set; }

        public string TACGIA { get; set; }

        public string NHAXUATBAN { get; set; }

        public int? SOLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONs { get; set; }
    }
}
