namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDrink")]
    public partial class OrderDrink
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ClientName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrinkID { get; set; }

        public int? Quantity { get; set; }

        public double? PriceTotal { get; set; }

        public virtual Client Client { get; set; }

        public virtual Drink Drink { get; set; }
    }
}
