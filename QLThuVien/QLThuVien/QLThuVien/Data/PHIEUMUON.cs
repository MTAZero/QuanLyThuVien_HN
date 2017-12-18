namespace QLThuVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUMUON")]
    public partial class PHIEUMUON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUMUON()
        {
            CHITIETMUONs = new HashSet<CHITIETMUON>();
        }

        public int ID { get; set; }

        public int? NHANVIENID { get; set; }

        public int? DOCGIAID { get; set; }

        public int? SOLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUON> CHITIETMUONs { get; set; }

        public virtual DOCGIA DOCGIA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
