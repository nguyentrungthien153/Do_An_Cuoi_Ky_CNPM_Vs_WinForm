namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheUser")]
    public partial class TheUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheUser()
        {
            Bills = new HashSet<Bill>();
        }

        [Key]
        [StringLength(60)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string Type { get; set; }

        [StringLength(30)]
        public string GroupUser { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }

        public virtual GroupUser GroupUser1 { get; set; }
    }
}
