namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberInformation")]
    public partial class MemberInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int memberID { get; set; }

        [StringLength(100)]
        public string MemberName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FoundedDate { get; set; }

        [StringLength(11)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string MemberAddress { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public virtual Member Member { get; set; }
    }
}
