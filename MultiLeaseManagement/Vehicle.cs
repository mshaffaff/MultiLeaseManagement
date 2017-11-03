namespace MultiLeaseManagement
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            Leases = new HashSet<Leas>();
        }

        [Key]
        [StringLength(25)]
        public string Vehicle_VIN { get; set; }

        public int ModelID { get; set; }

        public int TypeID { get; set; }

        public int ColorID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Year { get; set; }

        public int Kilometres_Travelled { get; set; }

        public bool LeasedBefor { get; set; }

        [Column(TypeName = "money")]
        public decimal Current_Vehicle_Val { get; set; }

        public bool AutoTransmission { get; set; }

        public bool HasAirCondition { get; set; }

        public bool HasPowerLock { get; set; }

        public virtual Color Color { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leas> Leases { get; set; }

        public virtual Model Model { get; set; }

        public virtual V_Type V_Type { get; set; }
    }
}
