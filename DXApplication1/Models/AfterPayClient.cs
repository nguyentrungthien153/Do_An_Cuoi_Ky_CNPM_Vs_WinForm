namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AfterPayClient")]
    public partial class AfterPayClient
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ClientName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BillID { get; set; }

        public TimeSpan? StartTime { get; set; }

        public TimeSpan? UseTime { get; set; }

        public double? PriceUnit { get; set; }

        public double? TotalMoney { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Client Client { get; set; }
    }
}
