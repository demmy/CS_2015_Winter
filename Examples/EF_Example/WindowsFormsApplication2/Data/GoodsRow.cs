namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoodsRow
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public double TotalPrice { get; set; }

        public bool IsActive { get; set; }

        public DateTime EditTime { get; set; }

        public int? Goods_Id { get; set; }

        public int? Order_Id { get; set; }

        public virtual Good Good { get; set; }

        public virtual Order Order { get; set; }
    }
}
