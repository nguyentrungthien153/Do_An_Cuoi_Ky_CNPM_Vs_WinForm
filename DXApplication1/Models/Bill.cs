namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            AfterPayClients = new HashSet<AfterPayClient>();
            BeforePayClients = new HashSet<BeforePayClient>();
        }

        public int BillID { get; set; }

        [StringLength(60)]
        public string FoundedUser { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FoundedDate { get; set; }

        public double? PriceTotal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AfterPayClient> AfterPayClients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeforePayClient> BeforePayClients { get; set; }

        public virtual TheUser TheUser { get; set; }
    }
}
