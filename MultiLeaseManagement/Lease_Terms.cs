namespace MultiLeaseManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lease_Terms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lease_Terms()
        {
            Leases = new HashSet<Leas>();
        }

        [Key]
        public int Lease_Terms_ID { get; set; }

        public int Number_of_Years { get; set; }

        public int Max_Kilometres { get; set; }

        [Column(TypeName = "money")]
        public decimal Extra_Mileage_Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leas> Leases { get; set; }
    }
}
