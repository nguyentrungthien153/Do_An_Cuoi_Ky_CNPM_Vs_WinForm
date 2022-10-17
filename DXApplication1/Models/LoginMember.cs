namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginMember")]
    public partial class LoginMember
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int memberID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ClientName { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? UseTime { get; set; }

        public TimeSpan? LeftTime { get; set; }

        public virtual Client Client { get; set; }

        public virtual Member Member { get; set; }
    }
}
