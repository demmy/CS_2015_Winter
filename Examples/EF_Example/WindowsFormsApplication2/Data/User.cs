namespace WindowsFormsApplication2.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public string Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime EditTime { get; set; }
        public int? PersonalInfo_Id { get; set; }
        public int? Role_Id { get; set; }
        public virtual PersonalInfo PersonalInfo { get; set; }
        public virtual Role Role { get; set; }
    }
}
