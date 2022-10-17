namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupClientAndGroupUser")]
    public partial class GroupClientAndGroupUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string GroupUserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string GroupClientName { get; set; }

        public double? GiaDichVu { get; set; }

        public virtual GroupClient GroupClient { get; set; }

        public virtual GroupUser GroupUser { get; set; }
    }
}
