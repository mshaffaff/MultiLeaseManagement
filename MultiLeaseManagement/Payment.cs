namespace MultiLeaseManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int PaymentID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public int? Lease_ID { get; set; }

        public virtual Leas Leas { get; set; }

        public bool Active { get; set; }

    }
}
