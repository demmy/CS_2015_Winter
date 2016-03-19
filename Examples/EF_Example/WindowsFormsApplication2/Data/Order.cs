namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Comments = new HashSet<Comment>();
            GoodsRows = new HashSet<GoodsRow>();
        }

        public int OrderId { get; set; }

        public double TotalCost { get; set; }

        public bool IsActive { get; set; }

        public DateTime EditTime { get; set; }

        public int? Customer_Id { get; set; }

        public int? Status_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsRow> GoodsRows { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }
    }
}
