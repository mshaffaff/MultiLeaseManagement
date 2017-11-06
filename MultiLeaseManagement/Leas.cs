namespace MultiLeaseManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Leases")]
    public partial class Leas
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Leas()
        {
            Audits = new HashSet<Audit>();
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int LeaseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_Lease_Begins { get; set; }

        [Column(TypeName = "date")]
        public DateTime First_Payment_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal Monthly_Payment_Amount { get; set; }

        public int Monthly_Payment_Number { get; set; }

        [Required]
        [StringLength(25)]
        public string Vehicle_VIN { get; set; }

        public int Customer_ID { get; set; }

        public int Lease_Terms_ID { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Audit> Audits { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Lease_Terms Lease_Terms { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }


        public bool Active { get; set; }
    }
}
