namespace WebsiteDuLichDiaPhuong.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HINHANH")]
    public partial class HINHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HINHANH()
        {
            DIADANHs = new HashSet<DIADANH>();
            TINTUCs = new HashSet<TINTUC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHinhAnh { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHinhAnh { get; set; }

        [Required]
        [StringLength(50)]
        public string MoTaHinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIADANH> DIADANHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINTUC> TINTUCs { get; set; }
    }
}
