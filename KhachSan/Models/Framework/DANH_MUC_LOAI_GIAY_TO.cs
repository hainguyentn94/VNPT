namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_MUC_LOAI_GIAY_TO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANH_MUC_LOAI_GIAY_TO()
        {
            DANH_MUC_KHACH_HANG = new HashSet<DANH_MUC_KHACH_HANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MALOAIGIAYTO { get; set; }

        [StringLength(255)]
        public string TENLOAIGIAYTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_MUC_KHACH_HANG> DANH_MUC_KHACH_HANG { get; set; }
    }
}
