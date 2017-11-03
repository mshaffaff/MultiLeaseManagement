namespace MultiLeaseManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Audit
    {
        [Key]
        public int Audit_ID { get; set; }

        public DateTime? Date_of_Change { get; set; }

        [StringLength(20)]
        public string Changed_Field { get; set; }

        [StringLength(20)]
        public string Old_Value { get; set; }

        [StringLength(20)]
        public string New_Value { get; set; }

        public int? Lease_ID { get; set; }

        public virtual Leas Leas { get; set; }
    }
}
