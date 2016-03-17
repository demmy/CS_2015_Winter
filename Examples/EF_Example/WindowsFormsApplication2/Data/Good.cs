namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Good
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Good()
        {
            Comments = new HashSet<Comment>();
            GoodsRows = new HashSet<GoodsRow>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string SKU { get; set; }

        public double Price { get; set; }

        public int Count { get; set; }

        public bool IsActive { get; set; }

        public DateTime EditTime { get; set; }

        public int? Category_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsRow> GoodsRows { get; set; }
    }
}
