namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupClient")]
    public partial class GroupClient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GroupClient()
        {
            Clients = new HashSet<Client>();
            GroupClientAndGroupUsers = new HashSet<GroupClientAndGroupUser>();
        }

        [Key]
        [StringLength(30)]
        public string GroupName { get; set; }

        [StringLength(120)]
        public string Discription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GroupClientAndGroupUser> GroupClientAndGroupUsers { get; set; }
    }
}
