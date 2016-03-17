namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comment
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public int Type { get; set; }

        public bool IsActive { get; set; }

        public DateTime EditTime { get; set; }

        public int? Goods_Id { get; set; }

        public int? Customer_Id { get; set; }

        public int? Order_Id { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Good Good { get; set; }

        public virtual Order Order { get; set; }
    }
}
