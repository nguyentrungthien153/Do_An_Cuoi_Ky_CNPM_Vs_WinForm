namespace DXApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            AfterPayClients = new HashSet<AfterPayClient>();
            BeforePayClients = new HashSet<BeforePayClient>();
            LoginMembers = new HashSet<LoginMember>();
            OrderCards = new HashSet<OrderCard>();
            OrderDrinks = new HashSet<OrderDrink>();
            OrderFoods = new HashSet<OrderFood>();
        }

        [Key]
        [StringLength(30)]
        public string ClientName { get; set; }

        [StringLength(30)]
        public string GroupClientName { get; set; }

        [StringLength(50)]
        public string StatusClient { get; set; }

        [StringLength(100)]
        public string Note { get; set; }

        [StringLength(100)]
        public string ActiveStatusClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AfterPayClient> AfterPayClients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeforePayClient> BeforePayClients { get; set; }

        public virtual GroupClient GroupClient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoginMember> LoginMembers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCard> OrderCards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDrink> OrderDrinks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderFood> OrderFoods { get; set; }
    }
}
