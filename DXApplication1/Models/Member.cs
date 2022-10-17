namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Member")]
    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            LoginMembers = new HashSet<LoginMember>();
        }

        public int MemberID { get; set; }

        [StringLength(30)]
        public string AccountName { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(30)]
        public string GroupUser { get; set; }

        public TimeSpan? CurrentTime { get; set; }

        public double? CurrentMoney { get; set; }

        [StringLength(30)]
        public string StatusAccount { get; set; }

        public virtual GroupUser GroupUser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginMember> LoginMembers { get; set; }

        public virtual MemberInformation MemberInformation { get; set; }
    }
}
