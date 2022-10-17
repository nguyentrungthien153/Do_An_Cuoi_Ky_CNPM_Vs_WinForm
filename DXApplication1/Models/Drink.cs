namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Drink")]
    public partial class Drink
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drink()
        {
            OrderDrinks = new HashSet<OrderDrink>();
        }

        public int DrinkID { get; set; }

        [StringLength(100)]
        public string DrinkName { get; set; }

        [StringLength(60)]
        public string CategoryName { get; set; }

        public double? PriceUnit { get; set; }

        [StringLength(100)]
        public string UnitLot { get; set; }

        public int? InventoryNumber { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDrink> OrderDrinks { get; set; }
    }
}
